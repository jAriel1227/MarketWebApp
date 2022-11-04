using Market.Core.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Market.Middlewares;
using Market.Core.Application.ViewModels.Articulos;
using System.IO;
using System;

namespace Market.WebApp.Controllers
{
    public class ArticulosController : Controller
    {
        private readonly IArticulosServices _articulosServices;
        private readonly ICategoriasServices _categoryService;
       // private readonly ValidateUserSession _validateUserSession;

        public ArticulosController(IArticulosServices articulosServices,
            ICategoriasServices categoriasServices/*, ValidateUserSession validateUser*/)
        {
            _articulosServices = articulosServices;
            _categoryService = categoriasServices;
        //    _validateUserSession = validateUser;
        }

        public async Task<IActionResult> Index()
        {
            return View( await _articulosServices.GetAllViewModelWithInclude());
        }
        public async Task<IActionResult> Crear()
        {
            /*if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Users", action = "Index" });
            }*/
            SaveArticulosViewModel vm = new();
            vm.CategoryList = await _categoryService.GetAllViewModel();
            return View("SaveArticles", vm);
        }
        [HttpPost]
        public async Task<IActionResult> Crear(SaveArticulosViewModel vm)
        {
           /* if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Users", action = "Index" });
            }*/
            if (!ModelState.IsValid)
            {
                vm.CategoryList = await _categoryService.GetAllViewModel();
                return View("SaveArticles", vm);
            }
            await _articulosServices.Add(vm);
            return RedirectToRoute(new { controller = "Articulos", action = "Index" });
        }
        public async Task<IActionResult> Editar(int id)
        {
            /*if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Users", action = "Index" });
            }*/
            SaveArticulosViewModel vm = await _articulosServices.GetByIdSaveViewModel(id);
            vm.CategoryList = await _categoryService.GetAllViewModel();
            return View("SaveArticles", vm);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(SaveArticulosViewModel vm)
        {
           /* if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Users", action = "Index" });
            }*/
            if (!ModelState.IsValid)
            {
                vm.CategoryList = await _categoryService.GetAllViewModel();
                return View("SaveArticles", vm);
            }
            SaveArticulosViewModel productVm = await _articulosServices.GetByIdSaveViewModel(vm.Id);
           //  vm.ImageUrl = UploadFile(vm.File, vm.Id, true, productVm.ImageUrl);

            await _articulosServices.Update(vm, vm.Id);
            return RedirectToRoute(new { controller = "Articles", action = "Index" });
        }
        public async Task<IActionResult> Eliminar(int id)
        {
            /*if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Users", action = "Index" });
            }*/
            return View("Delete", await _articulosServices.GetByIdSaveViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> EliminarA(int id)
        {
           /* if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Users", action = "Index" });
            }*/
            await _articulosServices.Delete(id);
            return RedirectToRoute(new { controller = "Articulos", action = "Index" });
        }
       /* private string UploadFile(IFormFile file, int id, bool isEditMode = false, string imagePath = "")
        {
            if (isEditMode)
            {
                if (file == null)
                {
                    return imagePath;
                }
            }
            string basePath = $"/Images/Articles/{id}";
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{basePath}");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            Guid guid = Guid.NewGuid();
            FileInfo fileInfo = new(file.FileName);
            string fileName = guid + fileInfo.Extension;

            string fileNameWithPath = Path.Combine(path, fileName);

            using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            if (isEditMode)
            {
                string[] oldImagePart = imagePath.Split("/");
                string oldImagePath = oldImagePart[^1];
                string completeImageOldPath = Path.Combine(path, oldImagePath);

                if (System.IO.File.Exists(completeImageOldPath))
                {
                    System.IO.File.Delete(completeImageOldPath);
                }
            }
            return $"{basePath}/{fileName}";
        }*/
    }
}
