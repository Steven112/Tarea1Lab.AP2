using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroOneAP2.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage ="Debe de haber un Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Debe de haber un Telefono")]
        public int Telefono { get; set; }
        [Required(ErrorMessage ="Debe de haber una Cedula")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Debe de haber una Direccion")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Debe de haber una Fecha")]
        public DateTime Nacimiento { get; set; }
        

        public Usuario()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            Telefono = 0;
            Cedula = string.Empty;
            Direccion = string.Empty;
            Nacimiento = DateTime.Now;

        }
    }  
}
