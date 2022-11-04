using Microsoft.AspNetCore.Mvc;

namespace Market.WebApp.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
