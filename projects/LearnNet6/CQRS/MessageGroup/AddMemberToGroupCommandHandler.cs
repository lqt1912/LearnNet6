using LearnNet6.Data.Entity;
using LearnNet6.Data.Repositories;
using MediatR;
using Microsoft.Data.SqlClient;

namespace LearnNet6.CQRS
{
    public class AddMemberToGroupCommand : IRequest<GroupMember?>
    {
        public Guid UserId { get; set; }
        public int GroupId { get; set; }
        public string UserRole { get; set; }
        public long CreatedDate { get; set; }
        public long ModifiedDate { get; set; }
    }

    public class AddMemberToGroupCommandHandler : IRequestHandler<AddMemberToGroupCommand, GroupMember?>
    {
        private readonly IGroupMemberRepository groupMemberRepository;
        private const string POST_SQL_QUERY =
            "insert into [GroupMember] values (@p1, @p2, @p3, @p4, @p5)";
        private const string GET_SQL_QUERY =
            "select * from [GroupMember] where Id  = (SELECT IDENT_CURRENT('GroupMember'))";

        public AddMemberToGroupCommandHandler(IGroupMemberRepository groupMemberRepository)
        {
            this.groupMemberRepository = groupMemberRepository;
        }


        public async Task<GroupMember?> Handle(AddMemberToGroupCommand request, CancellationToken cancellationToken)
        {
            var exec = groupMemberRepository.ExecuteNoneQuery(POST_SQL_QUERY,
                new SqlParameter("@p1", request.UserId),
                new SqlParameter("@p2", request.GroupId),
                new SqlParameter("@p3", request.UserRole),
                new SqlParameter("@p4", request.CreatedDate),
                new SqlParameter("@p5", request.ModifiedDate));

            if (exec > 0)
            {
                var result = groupMemberRepository.ExecuteSqlRawForQueryType(GET_SQL_QUERY).FirstOrDefault();
                return result;
            }
            else return new GroupMember();
        }
    }

    public class GroupMemberViewModel
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int GroupId { get; set; }
        public string UserRole { get; set; }
        public long CreatedDate { get; set; }
        public long ModifiedDate { get; set; }
    }
}
