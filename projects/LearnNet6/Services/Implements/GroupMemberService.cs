using AutoMapper;
using LearnNet6.CQRS;
using LearnNet6.Data.Entity;
using LearnNet6.Services.Interfaces;
using MediatR;

namespace LearnNet6.Services.Implements
{
    public class GroupMemberService : IGroupMemberService
    {
        private readonly IMediator _mediator;
        private readonly IMapper mapper;

        public GroupMemberService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            this.mapper = mapper;
        }

        public async Task<GroupMemberViewModel> AddMemberIntoGroup(AddMemberToGroupCommand command)
        {
            command.CreatedDate = DateTimeOffset.Now.ToUnixTimeSeconds();
            command.ModifiedDate = DateTimeOffset.Now.ToUnixTimeSeconds();
            var result = await _mediator.Send<GroupMember>(command);
            return mapper.Map<GroupMemberViewModel>(result);
        }
    }
}
