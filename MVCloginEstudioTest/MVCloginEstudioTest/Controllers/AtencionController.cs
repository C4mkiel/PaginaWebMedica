using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCloginEstudioTest.Models;
using MVCloginEstudioTest.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCloginEstudioTest.Controllers
{
    public class AtencionController : Controller
    {
        private IPacientesCollection db = new PacientesCollection();
        public IActionResult Index()
        {
            return View();
        }
        // GET: Medicamento/Create
        public ActionResult Create(string id)
        {
            AtencionViewModel AtencionVM = new AtencionViewModel() { IdPaciente = id, Atencion = new Atencion() };
            return View(AtencionVM);
        }

        // POST: Medicamento/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var pacientes = db.GetPacientes(collection["IdPaciente"]);
                if (pacientes.Atencion == null)
                    pacientes.Atencion = new List<Atencion>();

                pacientes.Atencion.Add(new Atencion
                {
                    Alergias = collection["Atencion.Alergias"],
                    SignoVital = collection["Atencion.SignoVital"],
                    EnfermedadCronica = collection["Atencion.EnfermedadCronica"],
                    Diagnostico = collection["Atencion.Diagnostico"],
                    Tratamiento = collection["Atencion.Tratamiento"]
                });
                db.UpdatePacientes(pacientes);
                return RedirectToAction("Index", "Pacientes");

            }
            catch
            {
                return View();
            }
        }
    }
}
