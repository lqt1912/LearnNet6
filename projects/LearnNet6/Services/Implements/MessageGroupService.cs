using AutoMapper;
using LearnNet6.CQRS;
using LearnNet6.Data.Entity;
using LearnNet6.Services.Implements;
using MediatR;

namespace LearnNet6.Services.Interfaces
{
    public class MessageGroupService : IMessageGroupService
    {
        private readonly IMapper mapper;
        private readonly IMediator _mediator;

        public MessageGroupService(IMapper mapper, IMediator mediator)
        {
            this.mapper = mapper;
            _mediator = mediator;
        }

        public async Task<MessageGroupViewModel> AddMessageGroup(AddMessageGroupCommand command)
        {
            command.CreatedDate = DateTimeOffset.Now.ToUnixTimeSeconds();
            command.ModifiedDate = DateTimeOffset.Now.ToUnixTimeSeconds();
            var result = await _mediator.Send<MessageGroup>(command);

            return mapper.Map<MessageGroupViewModel>(result);

        }
    }
}
