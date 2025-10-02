using Microsoft.AspNetCore.Mvc;
using Actividad3LengProg3.Models;
using System.Collections.Generic;
using System.Linq;

namespace Actividad3LengProg3.Controllers
{
    public class EstudiantesController : Controller
    {
        private static List<EstudianteViewModel> estudiantes = new List<EstudianteViewModel>();

        public IActionResult Index()
        {
            return View(new EstudianteViewModel());
        }

        [HttpPost]
        public IActionResult Registrar(EstudianteViewModel estudiante)
        {
            if (ModelState.IsValid)
            {
                estudiantes.Add(estudiante);
                return RedirectToAction("Lista");
            }
            return View("Index", estudiante);
        }

        public IActionResult Lista()
        {
            return View(estudiantes);
        }

        public IActionResult Editar(string matricula)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.Matricula == matricula);
            if (estudiante == null) return NotFound();
            return View(estudiante);
        }

        [HttpPost]
        public IActionResult Editar(EstudianteViewModel estudiante)
        {
            if (ModelState.IsValid)
            {
                var existente = estudiantes.FirstOrDefault(e => e.Matricula == estudiante.Matricula);
                if (existente != null)
                {
                    estudiantes.Remove(existente);
                    estudiantes.Add(estudiante);
                }
                return RedirectToAction("Lista");
            }
            return View(estudiante);
        }

        public IActionResult Eliminar(string matricula)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.Matricula == matricula);
            if (estudiante != null) estudiantes.Remove(estudiante);
            return RedirectToAction("Lista");
        }
    }
}

