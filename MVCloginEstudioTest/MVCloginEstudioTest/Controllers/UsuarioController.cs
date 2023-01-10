using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MVCloginEstudioTest.Models;
using MVCloginEstudioTest.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCloginEstudioTest.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioCollection db = new UsuarioCollection();
        // GET: UsuarioController
        public ActionResult Index()
        {
            var usuario = db.GetAllUsuario();
            return View(usuario);
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(string id)
        {
            var usuario = db.GetUsuario(id);
            return View(usuario);
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var usuario = new Usuario()
                {
                    Rut = collection["Rut"],
                    NombrePaciente = collection["NombrePaciente"],
                    CorreoUsuario = collection["CorreoUsuario"],
                    Contraseña = collection["Contraseña"]
                };

                db.InsertUsuario(usuario);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Editar datos usuario
        public ActionResult Edit(string id)
        {
            var usuario = db.GetUsuario(id);
            return View(usuario);
        }

        // POST: Editar datos usuario
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                var usuario = new Usuario()
                {
                    IdPaciente = new ObjectId(id),
                    Rut = collection["Rut"],
                    NombrePaciente = collection["NombrePaciente"],
                    CorreoUsuario = collection["CorreoUsuario"],
                    Contraseña = collection["Contraseña"]
                };

                db.UpdateUsuario(usuario);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(string id)
        {
            var usuario = db.GetUsuario(id);
            return View(usuario);
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                db.DeleteUsuario(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
