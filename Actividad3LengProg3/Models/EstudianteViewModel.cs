using System;
using System.ComponentModel.DataAnnotations;

namespace Actividad3LengProg3.Models
{
    public class EstudianteViewModel
    {
        [Required(ErrorMessage = "Debe proporcionar el nombre completo")]
        [StringLength(100)]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "Debe proporcionar la dirección")]
        [StringLength(200)]
        public string Direccion { get; set; }

        [Phone(ErrorMessage = "Debe proporcionar su número de contacto")]
        [MinLength(10)]
        public string Celular { get; set; }

        [Phone]
        [MinLength(10)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe proporcionar la fecha de nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Debe seleccionar el género")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Debe proporcionar una matrícula")]
        [StringLength(15, MinimumLength = 6)]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Debe seleccionar la carrera")]
        public string Carrera { get; set; }

        [Required(ErrorMessage = "Debe seleccionar el campus")]
        public string Campus { get; set; }

        [Required(ErrorMessage = "Debe proporcionar el correo institucional")]
        [EmailAddress]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Debe seleccionar la tanda de estudio")]
        public string Tanda { get; set; }

        public bool EstaBecado { get; set; }

        [Range(0, 100)]
        public int? PorcentajeBeca { get; set; }
    }
}
