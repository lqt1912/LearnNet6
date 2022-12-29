using LearnNet6.Models;
using LearnNet6.ViewModels;

namespace LearnNet6.Services
{
    public interface IUserServices
    {
        Task<object> Authenticate(LoginModel model);
        Task<object> Register(RegisterModel model);
        Task<IEnumerable<UserViewModel>> GetAllUser();
    }
}
