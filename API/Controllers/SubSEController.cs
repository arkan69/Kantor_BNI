using API.Base;
using API.Models;
using API.Repositories.Base;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubSEController : BaseController<SubSE, string, SubSERepositories>
	{
		private SubSERepositories _repo;
		public SubSEController(SubSERepositories repositories) : base(repositories)
		{
			_repo= repositories;
		}
	}
}
