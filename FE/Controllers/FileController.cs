using Microsoft.AspNetCore.Mvc;

namespace FE.Controllers
{
    public class FileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
