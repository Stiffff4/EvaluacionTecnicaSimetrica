using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Int64 Cedula { get; set; }
        public string Usuario_Nombre { get; set; }
        public string Contrasena { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha_Nacimiento { get; set; }
        public string Usuario_Transaccion { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha_Transaccion { get; set; }

        public Usuario()
        {
            Fecha_Transaccion = DateTime.Now;
            Usuario_Transaccion = "USER";
        }
    }
}
