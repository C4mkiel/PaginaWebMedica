using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MVCloginEstudioTest.Models;
using MVCloginEstudioTest.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList;

namespace MVCloginEstudioTest.Controllers
{
    public class PacientesController : Controller
    {
        private IPacientesCollection db = new PacientesCollection();
        // GET: PacientesController
        public ActionResult Index(string buscarPaciente)
        {
            var pacientes = db.GetAllPacientes();
            var Pacientes = from s in db.GetAllPacientes() select s;
            if (!String.IsNullOrEmpty(buscarPaciente)) {
                pacientes = pacientes.Where(s => s.NombrePaciente.Contains(buscarPaciente)
                || s.Rut.Contains(buscarPaciente)) as List<Pacientes>;
            }
            return View(pacientes);
        }


        // GET: PacientesController/Details/5
        public ActionResult Details(string id)
        {
            var pacientes = db.GetPacientes(id);
            return View(pacientes);
        }

        // GET: PacientesController/Details/5
        public ActionResult Buscar(string id)
        {
            var pacientes = db.GetPacientes(id);
            return View(pacientes);
        }


        // GET: PacientesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PacientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var pacientes = new Pacientes()
                {
                    Rut = collection["Rut"],
                    NombrePaciente = collection["NombrePaciente"],
                    ApellidoPaciente = collection["ApellidoPaciente"],
                    FechaNacimiento = DateTime.Parse(collection["FechaNacimiento"]),
                    MotConsulta = collection["MotConsulta"],
                    Consulta = collection["Consulta"]
                };
                db.InsertPacientes(pacientes);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PacientesController/Edit/5
        public ActionResult Edit(string id)
        {
            var pacientes = db.GetPacientes(id);
            return View(pacientes);
        }

        // POST: PacientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                var pacientes = new Pacientes()
                {
                    IdPaciente = new ObjectId(id),
                    Rut = collection["Rut"],
                    NombrePaciente = collection["NombrePaciente"],
                    ApellidoPaciente = collection["ApellidoPaciente"],
                    FechaNacimiento = DateTime.Parse(collection["FechaNacimiento"]),
                    MotConsulta = collection["MotConsulta"],
                    Consulta = collection["Consulta"]
                };
                db.UpdatePacientes(pacientes);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PacientesController/Delete/5
        public ActionResult Delete(string id)
        {
            var pacientes = db.GetPacientes(id);
            return View(pacientes);
        }

        // POST: PacientesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                db.DeletePacientes(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
