using LearnNet6.CQRS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnNet6.Controllers.v2
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v2")]
    [ApiVersion("2.0")]
    public class MessageGroupController : ControllerBase
    {

        [HttpPost("[action]")]
        public async Task<IActionResult> AddMessageGroup(AddMessageGroupCommand command)
        {
           
            return Ok(1);
        }
    }
}
