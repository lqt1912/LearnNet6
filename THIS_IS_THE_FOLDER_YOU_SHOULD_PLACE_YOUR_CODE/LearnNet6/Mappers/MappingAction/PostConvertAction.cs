using AutoMapper;
using LearnNet6.Data.Entity;
using LearnNet6.Data.Repositories;
using LearnNet6.Models.Responses;

namespace LearnNet6.Mappers.MappingAction
{
    public class PostConvertAction : IMappingAction<Post, PostResponse>
    {
        private readonly IUserRepository _userRepository;

        public PostConvertAction(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public void Process(Post source, PostResponse destination, ResolutionContext context)
        {
            try
            {
                var user = _userRepository.GetById(source.Id);
                destination.AuthorName = user.FirstName + " " + user.LastName;

            }
            catch (Exception)
            {
                //do nothing
            }
        }
    }
}
