using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_final
{
    internal class nomina1
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string periodo { get; set; }
        public string deduciones { get; set; }
        public string total { get; set; }
        public nomina1() { }
        public nomina1(int cedula, string nombre, string periodo, string deduciones, string total)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.periodo = periodo;
            this.deduciones = deduciones;
            this.total = total;
        }
    }
}
