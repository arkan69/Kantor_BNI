using API.Base;
using API.Models;
using API.Repositories.Base;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PelanggansController : BaseController<Pelanggan, string, PelangganRepositories>
    {
        private PelangganRepositories _repo;
        public PelanggansController(PelangganRepositories repositories) : base(repositories)
        {
            _repo= repositories;
        }
    }
}
