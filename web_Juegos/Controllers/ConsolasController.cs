using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using api_video_juegos.Models;

namespace web_video_juegos2.Controllers
{
    public class ConsolasController : Controller
    {
        video_juegos_bd bd = new video_juegos_bd();
        // GET: Consolas
        public ActionResult Index()
        {
            IEnumerable<consola> sistema = bd.consolas;
            return View(bd.consolas);
        }

        // GET: Consolas/Details/5
        public ActionResult Details(int id)
        {
            consola consola_buscada = bd.consolas.Find(id);
            return View(consola_buscada);
        }

        // GET: Consolas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consolas/Create
        [HttpPost]
        public ActionResult Create(consola nueva_consola)
        {
            try
            {
                // TODO: Add insert logic here
                bd.consolas.Add(nueva_consola);
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consolas/Edit/5
        public ActionResult Edit(int id)
        {
            consola consola_buscada = bd.consolas.Find(id);
            return View(consola_buscada);
        }

        // POST: Consolas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, consola consolita)
        {
            try
            {
                //Obtener consola a modificar
                consola consola_buscada = bd.consolas.Find(id);
                //Aplicar cambios a las consolas
                consola_buscada.marca = consolita.marca;
                consola_buscada.modelo = consolita.modelo;
                consola_buscada.nueva = consolita.nueva;
                consola_buscada.precio = consolita.precio;
                consola_buscada.stock = consolita.stock;
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consolas/Delete/5
        public ActionResult Delete(int id)
        {
            consola consola_buscada = bd.consolas.Find(id);
            return View(consola_buscada);
        }

        // POST: Consolas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                consola consola_buscada = bd.consolas.Find(id);
                bd.consolas.Remove(consola_buscada);
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
