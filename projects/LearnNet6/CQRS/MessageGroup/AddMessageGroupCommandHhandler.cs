
using LearnNet6.Data.Entity;
using LearnNet6.Data.Repositories;
using MediatR;
using Microsoft.Data.SqlClient;

namespace LearnNet6.CQRS
{
    public class AddMessageGroupCommand : IRequest<MessageGroup?>
    {

        public string GroupName { get; set; }
        public string GroupAlias { get; set; }
        public string AvatarUrl { get; set; }
        public long CreatedDate { get; set; }
        public long ModifiedDate { get; set; }
    }
    public class AddMessageGroupCommandHhandler : IRequestHandler<AddMessageGroupCommand, MessageGroup?>
    {
        private readonly IMessageGroupRepository messageGroupRepository;
        private const string SQL_QUERY =
            "insert into [MessageGroup] values (@p1, @p2, @p3, @p4, @p5)";
        public AddMessageGroupCommandHhandler(IMessageGroupRepository messageGroupRepository)
        {
            this.messageGroupRepository = messageGroupRepository;
        }

        public async Task<MessageGroup?> Handle(AddMessageGroupCommand request, CancellationToken cancellationToken)
        {

            var exec = messageGroupRepository.ExecuteNoneQuery(SQL_QUERY,
                 new SqlParameter("@p1", request.GroupName),
                 new SqlParameter("@p2", request.GroupAlias),
                 new SqlParameter("@p3", request.AvatarUrl),
                 new SqlParameter("@p4", request.CreatedDate),
                 new SqlParameter("@p5", request.ModifiedDate));
            if (exec > 0)
            {
                var result = messageGroupRepository.ExecuteSqlRawForQueryType("select * from MessageGroup where Id  = (SELECT IDENT_CURRENT('MessageGroup'))").FirstOrDefault();
                return result;

            }
            else return new MessageGroup();
        }
    }

    public class MessageGroupViewModel
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string GroupAlias { get; set; }
        public string AvatarUrl { get; set; }
        public long CreatedDate { get; set; }
        public long ModifiedDate { get; set; }

    }
}
