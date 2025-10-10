using Microsoft.AspNetCore.Mvc;
using Actividad3LengProg3.Models;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Actividad3LengProg3.Controllers
{
    public class EstudiantesController : Controller
    {
        private static List<EstudianteViewModel> estudiantes = new List<EstudianteViewModel>();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(EstudianteViewModel model)
        {
            if (ModelState.IsValid)
            {
                estudiantes.Add(model);
                return RedirectToAction("Index");

                TempData["SuccessMessage"] = "Estudiante agregado de forma exitosa.";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", model);
        }

        [HttpGet]
        public IActionResult ListaDeEstudiantes()
        {
            return View(estudiantes);
        }
        [HttpGet]
        public IActionResult Editar(string id)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.Matrícula.Equals(id, StringComparison.InvariantCultureIgnoreCase));

            if(estudiantes != null)
            {
                return View(estudiante);
            }

            return RedirectToAction("ListaDeEstudiantes", estudiante);
        }

        [HttpPost]
        public IActionResult Editar(EstudianteViewModel model)
        {
            if (ModelState.IsValid)
            {

                var estudiante = estudiantes.FirstOrDefault(e => e.Matrícula.Equals(model.Matrícula, StringComparison.InvariantCultureIgnoreCase));

                if (estudiantes != null)
                {
                    estudiante.NombreCompleto = model.NombreCompleto;
                    estudiante.Carrera = model.Carrera;
                    estudiante.Correo = model.Correo;
                    estudiante.Dirección = model.Dirección;
                    estudiante.Campus = model.Campus;
                    estudiante.FechaNacimiento = model.FechaNacimiento;
                    estudiante.Celular = model.Celular;
                    estudiante.Teléfono = model.Teléfono;
                    estudiante.Género = model.Género;
                    estudiante.Tanda = model.Tanda;

                    TempData["SuccessMessage"] = "El estudiante ha sido editado de forma exitosa.";
                    return View(estudiante);
                }

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index", model);
        }

        public IActionResult Eliminar(string matrícula)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.Matrícula == matrícula);
            if (estudiante != null) estudiantes.Remove(estudiante);
            return RedirectToAction("ListaDeEstudiantes");
        }
    }
}

