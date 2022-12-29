namespace LearnNet6.Services
{
	public static class ServicesExtension
	{
		public static void AddCustomExtensions(this IServiceCollection services)
		{
			services.AddScoped<IUserServices, UserService>();
			services.AddScoped<IPostServices, PostServices>();

		}
	}
}
