using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Laborario_01.Models
{
    
    [Table("t_producto")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("pk_eproducto")]
        public int pk_eproductro { get; set; }
        [Column("nombre")]
        public string nombre { get; set; }
        [Column("categoria")]
        public string categoria { get; set; }
        [Column("precio")]
        public double precio { get; set; }
        [Column("descuento")]
        public double descuento { get; set; }
    }
}
