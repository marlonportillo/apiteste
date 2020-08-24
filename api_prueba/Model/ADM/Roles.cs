using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api_prueba.Model
{
    [Table("Roles", Schema = "ADM")]
    public class Roles
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 IdRol { set; get; }
        public String Rol { set; get; }
    }
}
