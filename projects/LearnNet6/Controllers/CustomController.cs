using Azure.Core;
using LearnNet6.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace LearnNet6.Controllers
{
    public class CustomController : ControllerBase
    {
        private string _userId;

        public string UserId
        {
            get
            {
                var accessToken = Request.HttpContext.Request.Headers["Authorization"].ToString().Split(' ')[1];
                return JwtHelpers.DecodeJwt(accessToken);
            }
            set { _userId = value; }
        }

    }
}
