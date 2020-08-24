using api_prueba.DAO.Interfaces.ADM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api_prueba.Model
{
    [Table("Usuarios", Schema = "ADM")]
    public class Usuarios
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 IdUsuario { set; get; }
        public String Usuario { set; get; }
        public String Contrasenia { set; get; }

        public Int32 IdRol { set; get; }
        public Int32 IdEstado { set; get; }
        public String Correo { set; get; }
        public String Nombre { set; get; }
        public String Apellido { set; get; }

        [ForeignKey("IdRol")]
        public Roles rol { get; set; }
        [ForeignKey("IdEstado")]
        public Estados estado { get; set; }


    }
}
