using LearnNet6.Models.Requests;
using LearnNet6.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearnNet6.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class PostController : ControllerBase
	{
		private readonly IPostServices postService;

		public PostController(IPostServices postService)
		{
			this.postService = postService;
		}

		[HttpPost]
		public async Task<IActionResult> AddPost(AddPostRequest request)
		{
			var result = await postService.AddPost(request);
			return Ok(result);
		}

		[HttpGet]
		public async Task<IActionResult> GetAllPost()
		{
			var result  = await postService.GetAllPost();
			return Ok(result);
		}
	}
}
