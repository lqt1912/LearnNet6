using LearnNet6.Data.Repositories;
using LearnNet6.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LearnNet6.CQRS.Queries
{
    public class GetAllPostQuery : IRequest<IEnumerable<PostViewModel>>
    {

    }

    public class GetAllPostHandler : IRequestHandler<GetAllPostQuery, IEnumerable<PostViewModel>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPostRepository _postRepository;

        public GetAllPostHandler(IUserRepository userRepository, IPostRepository postRepository)
        {
            _userRepository = userRepository;
            _postRepository = postRepository;
        }


        public async Task<IEnumerable<PostViewModel>> Handle(GetAllPostQuery request, CancellationToken cancellationToken)
        {
            var posts = await _postRepository.GetAll().ToListAsync();
            var responses = posts.Select(x => new PostViewModel()
            {
                Title = x.Title,
                Id = x.Id.ToString().Substring(0, 5).ToUpper(),
                AuthorName = (_userRepository.GetById(x.Author.Id)).FirstName + (_userRepository.GetById(x.AuthorId)).LastName
            });
            return responses;
        }
    }
}
