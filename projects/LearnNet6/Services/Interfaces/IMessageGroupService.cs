using LearnNet6.CQRS;

namespace LearnNet6.Services.Implements
{
    public interface IMessageGroupService
    {
        Task<MessageGroupViewModel> AddMessageGroup(AddMessageGroupCommand command);
    }
}
