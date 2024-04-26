using Microsoft.AspNetCore.Mvc;

namespace Solução.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
