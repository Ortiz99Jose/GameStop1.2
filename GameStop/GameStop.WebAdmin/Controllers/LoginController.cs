using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace GameStop.WebAdmin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(System.Web.Mvc.FormCollection data)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}