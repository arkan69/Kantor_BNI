using API.Base;
using API.Models;
using API.Repositories.Base;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SektorEkonomiController : BaseController<SektorEkonomi, string, SektorEkonomRepositories>
	{
		private SektorEkonomRepositories _repo;
		public SektorEkonomiController(SektorEkonomRepositories repositories) : base(repositories)
		{
			_repo = repositories;
		}
	}
}
