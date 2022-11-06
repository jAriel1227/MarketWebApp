using Market.Core.Application.Interfaces.Services;
using Market.Core.Application.ViewModels.Usuarios;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Market.WebApp.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuariosServices _usersService;

        public UsuariosController(IUsuariosServices usersService)
        {
            _usersService = usersService;
        }

        public IActionResult Index()
        {
            return View();
        }
        /*[HttpPost]
        public async Task<IActionResult> Index(LoginUsersViewModel loginvm)
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            if (!ModelState.IsValid)
            {
                return View(loginvm);
            }
            UsuarioViewModel uservm = await _usersService.Login(loginvm);
            if (uservm != null)
            {
                HttpContext.Session.Set<UsuarioViewModel>("user", uservm);
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            else
            {
                ModelState.AddModelError("userValidation", "Datos incorrectos");
            }
            return View(loginvm);
        }*/
        public IActionResult RegisUsers()
        {
           /* if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }*/
            return View(new SaveUsuarioViewModel());
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("user");
            return RedirectToRoute(new { controller = "Users", action = "Index" });
        }
        [HttpPost]
        public async Task<IActionResult> RegisUsers(SaveUsuarioViewModel uservm)
        {
            /*if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            } */
            if (!ModelState.IsValid)
            {
                return View(uservm);
            }
            await _usersService.Add(uservm);
            return RedirectToRoute(new { controller = "Users", action = "Index" });
        }

    }
}
