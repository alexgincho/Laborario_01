using System;
using System.Collections.Generic;
using System.Collections;

#nullable disable

namespace Laborario_01.Models
{
    public partial class TAlumno
    {
        public int PkEalumno { get; set; }
        public string Cdni { get; set; }
        public string Cnombre { get; set; }
        public string Capellido { get; set; }
        public DateTime? Ffechanacimiento { get; set; }
        public string Ccarrera { get; set; }
        public BitArray Bgenero { get; set; }
    }
}
