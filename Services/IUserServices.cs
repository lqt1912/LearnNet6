using LearnNet6.Models;

namespace LearnNet6.Services
{
    public interface IUserServices
    {
        Task<object> Authenticate(LoginModel model);
        Task<object> Register(RegisterModel model);
    }
}
