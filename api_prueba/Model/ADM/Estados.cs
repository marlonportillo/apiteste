using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api_prueba.DAO.Interfaces.ADM
{
    [Table("Estados", Schema = "ADM")]
    public class Estados
    {
        [Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 IdEstado { set; get; }
        public String Estado { set; get; }
    }
}
