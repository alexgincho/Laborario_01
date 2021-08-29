using System;
using System.Collections.Generic;

#nullable disable

namespace Laborario_01.Models
{
    public partial class TProducto
    {
        public int PkEproducto { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double? Precio { get; set; }
        public double? Descuento { get; set; }
    }
}
