using LearnNet6.Data.Entity;
using LearnNet6.Data.Repositories;
using LearnNet6.ViewModels;
using MediatR;

namespace LearnNet6.CQRS.Commands
{
    public class AddPostCommand : IRequest<PostViewModel>
    {
        public string Title { get; set; }
        public Guid AuthorId { get; set; }
    }

    public class AddPostHandler : IRequestHandler<AddPostCommand, PostViewModel>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPostRepository _postRepository;

        public AddPostHandler(IUserRepository userRepository, IPostRepository postRepository)
        {
            _userRepository = userRepository;
            _postRepository = postRepository;
        }

        public async Task<PostViewModel> Handle(AddPostCommand request, CancellationToken cancellationToken)
        {
            var post = new Post()
            {
                AuthorId = request.AuthorId,
                Title = request.Title
            };
            _postRepository.Add(post);

            await _postRepository.SaveChangesAsync();
            var _post = await _postRepository.GetAsyncById(post.Id);
            var author = await _userRepository.GetAsyncById(_post.AuthorId);
            return new PostViewModel()
            {
                AuthorName = author.FirstName + author.LastName,
                Id = _post.Id.ToString(),
                Title = _post.Title,
            };
        }
    }
}
