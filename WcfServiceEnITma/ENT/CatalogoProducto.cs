using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class CatalogoProducto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
