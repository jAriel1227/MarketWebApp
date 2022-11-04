using Market.Core.Application.Interfaces.Services;
using Market.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticulosServices _articulosServices;
        private readonly ICategoriasServices _categoriasServices;
        public HomeController(IArticulosServices articulosServices, ICategoriasServices categoriasServices)
        {
            _articulosServices = articulosServices;
            _categoriasServices = categoriasServices;
        }

        public async Task<IActionResult> Index()
        {

            ViewBag.Categories = await _categoriasServices.GetAllViewModel();
            return View( await _articulosServices.GetAllViewModelWithInclude());
        }        
    }
}
