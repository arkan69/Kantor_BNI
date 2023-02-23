using API.Models;
using FE.Base;
using FE.Repositories.Data;
using Microsoft.AspNetCore.Mvc;

namespace FE.Controllers
{
    public class PelangganController : BaseController<Pelanggan, PelangganRepositories, string>
    {
        private readonly PelangganRepositories _repo;
        public PelangganController(PelangganRepositories repository) : base(repository)
        {
            this._repo= repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(string data)
        {
            ViewBag.Id = data;
            return View();
        }

        public IActionResult Insert() 
        { 
            return View(); 
        }
    }
}
