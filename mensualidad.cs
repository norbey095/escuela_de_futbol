using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_final
{
    internal class mensualidad
    {
       
        public int identificacion { get; set; }
        public string nombre { get; set; }
        public string mes { get; set; }
        public string valor { get; set; }

        public mensualidad() { }
        public mensualidad(int identificacion, string nombre, string mes, string valor)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.mes = mes;
            this.valor = valor;
        }
    }
}
