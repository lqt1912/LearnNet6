using LearnNet6.Models;
using LearnNet6.Services;
using LearnNet6.Validator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserServices userServices;

        public UserController(IUserServices userServices)
        {
            this.userServices = userServices;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            return Ok(await userServices.Authenticate(model));
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            RegisterModelValidator val = new RegisterModelValidator();
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
