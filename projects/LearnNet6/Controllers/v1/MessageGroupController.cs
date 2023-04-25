using LearnNet6.CQRS;
using LearnNet6.Services.Implements;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnNet6.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    [ApiVersion("1.0")]
    public class MessageGroupController : ControllerBase
    {
        private readonly IMessageGroupService messageGroupService;

        public MessageGroupController(IMessageGroupService messageGroupService)
        {
            this.messageGroupService = messageGroupService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddMessageGroup(AddMessageGroupCommand command)
        {
            var result = await messageGroupService.AddMessageGroup(command);
            return Ok(new OkObjectResult(result));

        }
    }
}
