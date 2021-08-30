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

        public IActionResult Mantenimiento(int id = 0)
        {
            TProducto producto = null;

            if (id != 0) producto = _sP.GetOne(id);

            ViewBag.lstCategoria = GetCategoria();

            return PartialView("_Mantenimiento",producto ?? new TProducto());
        }

        [HttpPost]
        public JsonResult MantenimientoProducto([FromBody]TProducto producto)
        {
            TProducto product = null;
            string error = "";
            try
            {
                if(producto.PkEproducto != 0)
                {
                    // actualiza
                    var update = _sP.GetOne(producto.PkEproducto);
                    product = _sP.CreateProduct(update);
                }
                else
                {
                    product = _sP.CreateProduct(producto);
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return Json(product);
        }

        public List<string> GetCategoria()
        {
            List<string> categoria = new List<string>();
            categoria.Add("Accion");
            categoria.Add("Arcade");
            categoria.Add("Deportivo");
            categoria.Add("Estrategia");
            categoria.Add("Simulacion");

            return categoria;
        }
    }
}
