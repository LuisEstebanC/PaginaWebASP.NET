using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Socios.Models
{
    [Table("Socio")]
    public class SocioModel
    {   
        [Key]
        public long Id { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Apellido { get; set; }
        [Required]
        [Display(Name = "Cedula")]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Cedula { get; set; }
        [Display(Name = "Foto")]
        public string Foto { get; set; }
        [Required]
        [Display(Name = "Direccion")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Direccion { get; set; }
        [Display(Name = "Telefono")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        public string Telefono { get; set; }
        [Display(Name = "Celular")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        public string Celular { get; set; }
        [Display(Name = "Fax")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Fax { get; set; }
        [Display(Name = "Sexo")]
        public char Sexo { get; set; }

        [Required]
        [Display(Name = "Edad")]
        public int Edad { get; set; }
        
        [Required]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime Fecha_de_nacimiento { get; set; }
        
        [Display(Name = "Afilidados")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Afiliados { get; set; }

       
        [Required]
        [Display(Name = "Datos de membrecia")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Datos_de_membresia { get; set; }
        
        [Display(Name = "Lugar de trabajo")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Lugar_de_trabajo { get; set; }
        
        [Display(Name = "Direccion de la oficina")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Direccion_de_oficina { get; set; }
        [Display(Name = "Telefono de la oficina")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        public string Tel_Oficina { get; set; }
        [Required]
        [Display(Name = "Estado de menbrecia")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Estado_Membresia { get; set; }
        [Required]
        [Display(Name = "Fecha de ingreso")]
        public DateTime Fecha_de_ingreso { get; set; }
        [Required]
        [Display(Name = "Fecha de salida")]
        public DateTime Fecha_de_salida { get; set; }


    }
}
