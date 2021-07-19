using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    [Table("Role")]
    public class Roles
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Usuario_Transaccion { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha_Transaccion { get; set; }

        public Roles()
        {
            Fecha_Transaccion = DateTime.Now;
            Usuario_Transaccion = "USER";
        }
    }
}
