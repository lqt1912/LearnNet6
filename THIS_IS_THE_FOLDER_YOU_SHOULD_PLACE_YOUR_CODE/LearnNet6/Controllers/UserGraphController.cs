using LearnNet6.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text.Json;

namespace LearnNet6.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class UserGraphController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UserGraphController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> GetCurrentUser()
        {
            var accessToken = Request.HttpContext.Request.Headers["Authorization"].ToString();
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://graph.microsoft.com/v1.0/users")
            {
                Headers =
                {
                    {HeaderNames.Authorization, accessToken }
                }
            };
            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var stringObject = await httpResponseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<GraphResponse>(stringObject);
                return Ok(result);
            }
            return Ok(httpResponseMessage.Content);
        }
    }
}
