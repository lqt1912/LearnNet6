using LearnNet6.Data;
using LearnNet6.Data.Entity;
using LearnNet6.Models;
using LearnNet6.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using OfficeOpenXml;
using System.Reflection;
using System.Text.Json;

namespace LearnNet6.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class UserGraphController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ApplicationDbContext _context;
        public UserGraphController(IHttpClientFactory httpClientFactory, ApplicationDbContext context)
        {
            _httpClientFactory = httpClientFactory;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserList(string? keyword)
        {
            keyword = keyword ?? String.Empty;
            RestSharp.RestClient restClient = new RestSharp.RestClient("https://graph.microsoft.com/v1.0");

            RestSharp.IRestRequest request = new RestSharp.RestRequest("users", RestSharp.Method.GET);

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                request.AddParameter("$search", $"\"displayName:{keyword}\" OR \"userPrincipalName:{keyword}\"  OR \"mail:{keyword}\"");
            }
            var accessToken = Request.HttpContext.Request.Headers["Authorization"].ToString();
            request.AddHeader("Authorization", accessToken);
            request.AddHeader("ConsistencyLevel", "eventual");
            var result = restClient.Execute(request);

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var graphUserDto = System.Text.Json.JsonSerializer.Deserialize<GraphResponse>(result.Content);

                return Ok(graphUserDto);
            }
            return Ok(1);

        }

        [HttpGet]
        public async Task<IActionResult> DecodeToken()
        {
            var accessToken = Request.HttpContext.Request.Headers["Authorization"].ToString().Split(' ')[1];
            var userId = JwtHelpers.DecodeJwt(accessToken);
            var currentUser = await _context.AdUsers.FirstOrDefaultAsync(x => x.id == userId);
            return Ok(currentUser);
        }

        [HttpGet]
        public async Task<IActionResult> ImportExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var response = new List<AdUser>();
            var package = new ExcelPackage(new FileInfo(@"C:\Users\thang\Downloads\exportUser.xlsx"));

            var firstSheet = package.Workbook.Worksheets["exportUser"];

            for (int row = 2; row < 11; row++)
            {

                AdUser record = new AdUser();
                PropertyInfo[] properties = typeof(AdUser).GetProperties();
                for (int i = 0; i < properties.Count() - 1; i++)
                {
                    properties[i].SetValue(record, firstSheet.Cells[row, i + 1].Text);
                }

                var exist = _context.AdUsers.AsNoTracking().FirstOrDefault(x => x.id == record.id);
                if (exist == null)
                {
                    record.Id = Guid.NewGuid();
                    _context.AdUsers.Add(record);
                    _context.SaveChanges();
                }
                else
                {
                    record.Id = exist.Id;
                    _context.AdUsers.Update(record);
                    _context.SaveChanges();
                }
                response.Add(record);

            }

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> RegisterToken(string deviceToken)
        {
            var accessToken = Request.HttpContext.Request.Headers["Authorization"].ToString().Split(' ')[1];
            var userId = JwtHelpers.DecodeJwt(accessToken);
            var currentUser = await _context.AdUsers.FirstOrDefaultAsync(x => x.id == userId);
            if (currentUser != null)
            {
                var tokenObject = new NotificationToken()
                {
                    Id = Guid.NewGuid(),
                    UserId = currentUser.Id,
                    Value = deviceToken
                };
                var existToken = _context.NotificationToken.Where(x => x.Value == deviceToken && x.UserId == currentUser.Id);
                if (existToken.Count() == 0)
                {
                    _context.NotificationToken.Add(tokenObject);
                    await _context.SaveChangesAsync();
                    return Ok($"Saved: {deviceToken}");
                }
                else return Ok($"Not saved: {deviceToken}");
               
            }
            else return Ok($"Not saved: {deviceToken}, null User");
        }

        [HttpGet]
        public async Task<IActionResult> RemoveToken(string deviceToken)
        {
            var accessToken = Request.HttpContext.Request.Headers["Authorization"].ToString().Split(' ')[1];
            var userId = JwtHelpers.DecodeJwt(accessToken);
            var currentUser = await _context.AdUsers.FirstOrDefaultAsync(x => x.id == userId);
            if (currentUser != null)
            {
                var tokenObject = _context.NotificationToken.Where(x => x.Value == deviceToken && x.UserId == currentUser.Id).AsNoTracking();
                if (tokenObject.Count() > 0)
                {
                    foreach (var item in tokenObject)
                    {
                        _context.NotificationToken.Remove(item);
                    }
                }
                await _context.SaveChangesAsync();
                return Ok($"Deleted {deviceToken}");
            }
            return Ok($"Deleted {deviceToken} not success, error user");

        }
    }
}
