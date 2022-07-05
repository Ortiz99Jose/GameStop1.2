using GameStop.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStop.web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1 ;
            producto1.Descripcion = "Fifa 2016";
          
            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Fifa 2016";

            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);

            return View(listadeProductos);
        }
    }
}