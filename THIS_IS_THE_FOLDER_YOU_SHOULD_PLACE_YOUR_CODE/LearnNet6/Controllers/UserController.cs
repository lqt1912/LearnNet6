using LearnNet6.Models;
using LearnNet6.Services;
using LearnNet6.Validator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnNet6.Controllers
{
    
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IUserServices userServices;

        public UserController(IUserServices userServices)
        {
            this.userServices = userServices;
        }

        /// <summary>
        /// Đăng nhập.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            return Ok(await userServices.Authenticate(model));
        }

        /// <summary>
        /// Đăng kí người dùng mới.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            var val = new RegisterModelValidator();
            var validationResult = val.Validate(model);
            if (validationResult.IsValid)
            {
                return Ok(await userServices.Register(model));
            }
            else
            {
                return Ok(String.Join(",", validationResult.Errors.Select(c => c.ErrorMessage)));
            }
        }
    }
}
