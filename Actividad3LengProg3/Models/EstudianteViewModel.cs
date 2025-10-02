using System;
using System.ComponentModel.DataAnnotations;

namespace Actividad3LengProg3.Models
{
    public class EstudianteViewModel
    {
        [Required, StringLength(100)]
        [Display(Name = "Nombre completo")]
        public string NombreCompleto { get; set; }

        [Required, StringLength(15, MinimumLength = 6)]
        public string Matricula { get; set; }

        [Required]
        public string Carrera { get; set; }

        [Required]
        public string Recinto { get; set; }

        [Required, EmailAddress]
        [Display(Name = "Correo institucional")]
        public string Correo { get; set; }

        [Phone, MinLength(10)]
        public string Celular { get; set; }

        [Phone, MinLength(10)]
        public string Telefono { get; set; }

        [Required, StringLength(200)]
        public string Direccion { get; set; }

        [Required, DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        public string Turno { get; set; }

        [Display(Name = "¿Está becado?")]
        public bool EstaBecado { get; set; }

        [Range(0, 100)]
        [Display(Name = "Porcentaje de beca")]
        public int? PorcentajeBeca { get; set; }
    }
}

