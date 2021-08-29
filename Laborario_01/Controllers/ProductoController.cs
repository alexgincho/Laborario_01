using Laborario_01.Models;
using Laborario_01.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborario_01.Controllers
{
    public class ProductoController : Controller
    {
        public IProductoService _sP;
        public ProductoController(IProductoService sp)
        {
            _sP = sp;
        }
        public IActionResult Index()
        {
            var p = _sP.GetAllProduct();
            
            return View(p);
        
        }

    }
}
