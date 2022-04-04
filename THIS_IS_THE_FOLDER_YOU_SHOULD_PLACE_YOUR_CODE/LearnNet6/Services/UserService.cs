using LearnNet6.Data;
using LearnNet6.Data.Entity;
using LearnNet6.Data.Repositories;
using LearnNet6.Models;
using LearnNet6.Utilities;
using LearnNet6.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LearnNet6.Services
{
    public class UserService : IUserServices
    {
        readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserEmailStore<ApplicationUser> _emailStore;
        private readonly ApplicationDbContext dbContext;
        private readonly IUserRepository userRepository;
        private readonly IConfiguration configuration;
        private readonly IRefreshTokenRepository refreshTokenRepository;
        public UserService(SignInManager<ApplicationUser> signInManager,
            IUserStore<ApplicationUser> userStore,
            UserManager<ApplicationUser> userManager,
            ApplicationDbContext dbContext,
            IUserRepository userRepository,
            IConfiguration configuration,
            IRefreshTokenRepository refreshTokenRepository)
        {
            _signInManager = signInManager;
            _userStore = userStore;
            _userManager = userManager;
            _emailStore = GetEmailStore();
            this.dbContext = dbContext;
            this.userRepository = userRepository;
            this.configuration = configuration;
            this.refreshTokenRepository = refreshTokenRepository;
        }

        public async Task<object> Authenticate(LoginModel model)
        {
            SignInResult? result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
            if (result.Succeeded)
            {
                var loginUser = await _userManager.FindByNameAsync(model.Email);

                if (loginUser != null)
                {
                    var claims = new Claim[]
                    {
                        new Claim(ClaimTypes.Name,"Name"),
                        new Claim(ClaimTypes.Role, "ClaimRole"),
                        new Claim("Id", loginUser.Id.ToString()),
                        new Claim(JwtRegisteredClaimNames.Sub, model.Email),
                        new Claim(JwtRegisteredClaimNames.Email, model.Email)
                    };

                    var jwtToken = JwtHelpers.CreateToken(configuration, claims);
                    var refreshToken = JwtHelpers.GetNewRefreshToken(configuration, loginUser.Id);
                    if (refreshToken != null)
                    {
                        var query = "SELECT  * FROM RefreshTokens WHERE UserId = @UserId and IsDeleted = @IsDeleted";
                        var oldRefreshTokens = refreshTokenRepository.ExecuteSqlRaw(query , new SqlParameter("UserId", loginUser.Id),new SqlParameter("IsDeleted", false)).ToList();
                        if (oldRefreshTokens.Any())
                        {
                            foreach (var item in oldRefreshTokens)
                            {
                                item.IsDeleted = true;
                                refreshTokenRepository.Update(item);
                            }
                        }
                        await refreshTokenRepository.SaveChangesAsync();
                        refreshTokenRepository.Add(refreshToken);
                        await refreshTokenRepository.SaveChangesAsync();

                    }

                    return jwtToken;
                }
                return null;

            }
            else
                return "Nothing";
        }

        private ApplicationUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<ApplicationUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
                    $"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        public async Task<object> Register(RegisterModel model)
        {
            var user = CreateUser();

            await _userStore.SetUserNameAsync(user, model.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(user, model.Email, CancellationToken.None);
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var userId = await _userManager.GetUserIdAsync(user);
                var _user = await userRepository.GetAsyncById(Guid.Parse(userId));
                if (_user == null) return null;

                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                return code;
            }
            return "Nothing";

        }
        private IUserEmailStore<ApplicationUser> GetEmailStore()
        {

            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<ApplicationUser>)_userStore;
        }

        public async Task<IEnumerable<UserViewModel>> GetAllUser()
        {
            var list = await userRepository.GetAll().ToListAsync();
            var response = list.Select(x => new UserViewModel()
            {
                Email = x.Email,
                Fullname = x.FirstName + x.LastName
            });
            return response;

        }
    }
}
