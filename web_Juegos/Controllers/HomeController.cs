using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_video_juegos2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descripción";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página para contacto directo.";

            return View();
        }
    }
}