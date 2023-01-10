using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCProyectoClase.Models;
using MVCProyectoClase.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProyectoClase.Controllers
{
    public class MedicamentoController : Controller
    {
        private IRecetasCollection db = new RecetasCollection();
        public IActionResult Index()
        {
            return View();
        }
        // GET: Medicamento/Create
        public ActionResult Create(string id)
        {
            MedicamentoViewModel MedicamentoVM = new MedicamentoViewModel() { IdReceta = id, Medicamento = new Medicamento() };
            return View(MedicamentoVM);
        }

        // POST: Medicamento/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var recetas = db.GetRecetas(collection["IdReceta"]);
                if (recetas.Medicamento == null)
                    recetas.Medicamento = new List<Medicamento>();

                    recetas.Medicamento.Add(new Medicamento
                    {
                        Nombre = collection["Medicamento.Nombre"],
                        Cantidad = collection["Medicamento.Cantidad"],
                        Comprimido = collection["Medicamento.Comprimido"],
                        HoraConsumo = collection["Medicamento.HoraConsumo"],
                        TiempoConsumo = collection["Medicamento.TiempoConsumo"]
                    });
                    db.UpdateRecetas(recetas);
                    return RedirectToAction("Index","Recetas");
              
            }
            catch
            {
                return View();
            }
        }
    }
}
