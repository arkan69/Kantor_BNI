using API.Base;
using API.Models;
using API.Repositories.Base;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubSubSEController : BaseController<SubSubSE, string, SubSubSERepositories>
	{
		private SubSubSERepositories _repo;
		public SubSubSEController(SubSubSERepositories repositories) : base(repositories)
		{
			_repo= repositories;
		}
	}
}
