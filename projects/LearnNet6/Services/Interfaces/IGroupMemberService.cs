using LearnNet6.CQRS;

namespace LearnNet6.Services.Interfaces
{
    public interface IGroupMemberService
    {
        Task<GroupMemberViewModel> AddMemberIntoGroup(AddMemberToGroupCommand command);
    }
}
