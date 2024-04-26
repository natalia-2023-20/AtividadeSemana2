using Microsoft.AspNetCore.Mvc;

namespace Solução.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
