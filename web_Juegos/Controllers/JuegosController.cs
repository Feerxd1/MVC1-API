using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using api_video_juegos.Models;

namespace web_video_juegos2.Controllers
{
    public class JuegosController : Controller
    {
        video_juegos_bd bd = new video_juegos_bd();
        // GET: Juegos
        public ActionResult Index()
        {
            IEnumerable<juego> sistema = bd.juegos;
            return View(bd.juegos);
        }

        // GET: Juegos/Details/5
        public ActionResult Details(int id)
        {
            juego juego_buscado = bd.juegos.Find(id);
            return View(juego_buscado);
        }

        // GET: Juegos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Juegos/Create
        [HttpPost]
        public ActionResult Create(juego new_juego)
        {
            try
            {
                // TODO: Add insert logic here
                bd.juegos.Add(new_juego);
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juegos/Edit/5
        public ActionResult Edit(int id)
        {
            juego juego_buscado = bd.juegos.Find(id);
            return View(juego_buscado);
        }

        // POST: Juegos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, juego jueguito)
        {
            try
            {
                //Obtener el juego a modificar
                juego juego_buscado = bd.juegos.Find(id);
                //Aplicar cambios a sus propiedades
                juego_buscado.nombre = jueguito.nombre;
                juego_buscado.plataforma = jueguito.plataforma;
                juego_buscado.precio = jueguito.precio;
                juego_buscado.restriccion = jueguito.restriccion;
                juego_buscado.stock = jueguito.stock;

                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juegos/Delete/5
        public ActionResult Delete(int id)
        {
            juego juego_buscado = bd.juegos.Find(id);
            return View(juego_buscado);
        }

        // POST: Juegos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                juego juego_buscado = bd.juegos.Find(id);
                bd.juegos.Remove(juego_buscado);
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
