using LearnNet6.Models.Requests;
using LearnNet6.Models.Responses;
using LearnNet6.ViewModels;

namespace LearnNet6.Services
{
    public interface IPostServices
    {
        Task<PostViewModel> AddPost(AddPostRequest request);
        Task<IEnumerable<PostViewModel>> GetAllPost();
    }
}
