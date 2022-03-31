using AutoMapper;
using LearnNet6.Data.Entity;
using LearnNet6.Data.Repositories;
using LearnNet6.Models.Responses;

namespace LearnNet6.Mappers.MappingAction
{
    public class PostConvertAction : IMappingAction<Post, PostResponse>
    {
        readonly IUserRepository userRepository;

        public PostConvertAction(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Process(Post source, PostResponse destination, ResolutionContext context)
        {
            try
            {
                var user = userRepository.GetById(source.Id);
                if (user == null)
                    return;
                destination.AuthorName = user.FirstName + " " + user.LastName;

            }
            catch (Exception)
            {
                //do nothing
            }
        }
    }
}
