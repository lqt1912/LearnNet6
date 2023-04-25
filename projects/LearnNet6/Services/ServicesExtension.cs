using LearnNet6.Services.Implements;
using LearnNet6.Services.Interfaces;

namespace LearnNet6.Services
{
	public static class ServicesExtension
	{
		public static void AddCustomExtensions(this IServiceCollection services)
		{
			services.AddScoped<IUserServices, UserService>();
			services.AddScoped<IPostServices, PostServices>();
			services.AddScoped<IMessageGroupService, MessageGroupService>();
			services.AddScoped<IGroupMemberService, GroupMemberService>();
		}
	}
}
