﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStop.BL;

namespace GameStop.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductosActivos();

            ViewBag.adminWebsiteUrl = ConfigurationManager.AppSettings["adminWebsiteUrl"];

            return View(listadeProductos);
        }
    }
}