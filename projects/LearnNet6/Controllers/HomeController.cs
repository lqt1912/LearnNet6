using LearnNet6.Data.Entity;
using LearnNet6.Models;
using LearnNet6.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LearnNet6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IUserServices userService;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        public HomeController(ILogger<HomeController> logger, IUserServices userService, IHttpContextAccessor httpContextAccessor, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            this.userService = userService;
            this.httpContextAccessor = httpContextAccessor;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.CurrentUser = userManager.GetUserId(User);
            ViewBag.Users = await userService.GetAllUser();

            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}