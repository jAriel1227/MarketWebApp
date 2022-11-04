using Market.Core.Application.Interfaces.Services;
using Market.Core.Application.ViewModels.Categorias;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Market.WebApp.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ICategoriasServices _categoryService;

        public CategoriasController(ICategoriasServices categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            /*if (!_validateUserSession.HasUser()) //Validacion del user
            {
                return RedirectToRoute(new { controller = "Users", action = "Index" });
            }*/
            return View(await _categoryService.GetAllViewModelWithInclude());
        }

        public IActionResult Crear()
        {
            SaveCategoriaViewModel vm = new();            
            /*if (!_validateUserSession.HasUser()) //Validacion del user
            {
                return RedirectToRoute(new { controller = "Users", action = "Index" });
            }*/
            return View("SaveCategory",vm);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(SaveCategoriaViewModel vm)
        {
           /*if (!_validateUserSession.HasUser()) //Validacion del user
            {
                return RedirectToRoute(new { controller = "Users", action = "Index" });
            }*/
            if (!ModelState.IsValid)
            {
                return View("SaveCategory", vm);
            }
            await _categoryService.Add(vm);
            return RedirectToRoute(new { controller = "Categorias", action = "Index" });
        }

        public async Task<IActionResult> Editar(int id)
        {
           /*if(!_validateUserSession.HasUser()) //Validacion para el user
             {
               return RedirectToRoute(new { controller = "Users", action = "Index" });
             }*/
            return View("SaveCategory", await _categoryService.GetByIdSaveViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> Editar(SaveCategoriaViewModel vm)
        {
            /*if(!_validateUserSession.HasUser()) //Validacion para el user
            {
               return RedirectToRoute(new { controller = "Users", action = "Index" });
            }*/
            if (!ModelState.IsValid)
            {
                return View("SaveCategory", vm);
            }

            await _categoryService.Update(vm, vm.Id);
            return RedirectToRoute(new { controller = "Categorias", action = "Index" });
        }

        public async Task<IActionResult> Eliminar(int id)
        {
           /*if (!_validateUserSession.HasUser()) //Validacion para el user
            {
                return RedirectToRoute(new { controller = "Users", action = "Index" });
            }*/
            return View("Delete", await _categoryService.GetByIdSaveViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> EliminarC(int id)
        {
           /* if (!_validateUserSession.HasUser()) //Validacion para el user
            {
                return RedirectToRoute(new { controller = "Users", action = "Index" });
            }*/
            await _categoryService.Delete(id);
            return RedirectToRoute(new { controller = "Categorias", action = "Index" });
        }
    }
}
