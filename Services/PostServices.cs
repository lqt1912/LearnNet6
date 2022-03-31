using AutoMapper;
using LearnNet6.CQRS.Commands;
using LearnNet6.CQRS.Queries;
using LearnNet6.Data.Repositories;
using LearnNet6.Models.Requests;
using LearnNet6.ViewModels;
using MediatR;

namespace LearnNet6.Services
{
    public class PostServices : IPostServices
    {
        private readonly IPostRepository postRepository;
        private readonly IMapper mapper;
        private readonly IMediator _mediator;
        public PostServices(IPostRepository postRepository, IMapper mapper, IMediator mediator)
        {
            this.postRepository = postRepository;
            this.mapper = mapper;
            _mediator = mediator;
        }

        public async Task<PostViewModel> AddPost(AddPostRequest request)
        {
            var command = new AddPostCommand()
            {
                Title = request.Title,
                AuthorId = request.AuthorId
            };
            return await _mediator.Send(command);
        }

        public async Task<IEnumerable<PostViewModel>> GetAllPost()
        {
            var query = new GetAllPostQuery();
            return await _mediator.Send(query);
        }
    }
}
