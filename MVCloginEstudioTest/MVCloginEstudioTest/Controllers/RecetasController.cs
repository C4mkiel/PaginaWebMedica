using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MVCProyectoClase.Models;
using MVCProyectoClase.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProyectoClase.Controllers
{
    public class RecetasController : Controller
    {
        private IRecetasCollection db = new RecetasCollection();
        // GET: RecetasController
        public ActionResult Index()
        {
            var recetas = db.GetAllRecetas();
            return View(recetas);
        }
        public ActionResult IndexPaciente(string RutPaciente)
        {
            string txtRut = Request.Form["RutPaciente"].ToString();
            var recetas = db.GetRecetasRut(txtRut);
            return View(recetas);
        }

        // GET: RecetasController/Details/5
        public ActionResult Details(string id)
        {
            var recetas = db.GetRecetas(id);
            return View(recetas);
        }
        public ActionResult DetailsPaciente(string id)
        {
            var recetas = db.GetRecetas(id);
            return View(recetas);
        }

        // GET: RecetasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecetasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var recetas = new Recetas()
                {
                    RecetaMedicaNombre = collection["RecetaMedicaNombre"],
                    RutPaciente = collection["RutPaciente"],
                    NombrePaciente = collection["NombrePaciente"],
                    EdadPaciente = collection["EdadPaciente"],
                    DomicilioPaciente = collection["DomicilioPaciente"],
                    FechaReceta = DateTime.Parse(collection["FechaReceta"]),
                    ComentarioReceta = collection["ComentarioReceta"],
                    NombreDoctor = collection["NombreDoctor"]
                };
                db.InsertReceta(recetas);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecetasController/Edit/5
        public ActionResult Edit(string id)
        {
            var recetas = db.GetRecetas(id);
            return View(recetas);
        }

        // POST: RecetasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                var recetas = new Recetas()
                {
                    IdReceta = new ObjectId(id),
                    RecetaMedicaNombre = collection["RecetaMedicaNombre"],
                    NombrePaciente = collection["NombrePaciente"],
                    EdadPaciente = collection["EdadPaciente"],
                    DomicilioPaciente = collection["DomicilioPaciente"],
                    FechaReceta = DateTime.Parse(collection["FechaReceta"]),
                    ComentarioReceta = collection["ComentarioReceta"],
                    NombreDoctor = collection["NombreDoctor"]
                };
                db.UpdateRecetas(recetas);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecetasController/Delete/5
        public ActionResult Delete(string id)
        {
            var recetas = db.GetRecetas(id);
            return View(recetas);
        }

        // POST: RecetasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                db.DeleteRecetas(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
