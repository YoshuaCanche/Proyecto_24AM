using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_24AM.Models
{
    public class Usuario
    {
        //Primary key
        [Key]
        public int PkUsuario { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        [ForeignKey("Roles")]
        //Llamar a objeto rol
        public int? FkRol { get; set; }
        public Roles Rol { get; set; }

        





    }
}
