using LearnNet6.CQRS;
using LearnNet6.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnNet6.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    [ApiVersion("1.0")]
    public class GroupMemberController : ControllerBase
    {
        private readonly IGroupMemberService groupMemberService;

        public GroupMemberController(IGroupMemberService groupMemberService)
        {
            this.groupMemberService = groupMemberService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddMemberToGroup(AddMemberToGroupCommand command)
        {
            var result = groupMemberService.AddMemberIntoGroup(command);
            return Ok(new OkObjectResult(result));
        }
    }
}
