using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_final
{
    internal class Inventario1
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string cantidad { get; set; }
        public int costou { get; set; }
        public int costot { get; set; }
        public Inventario1() { }
        public Inventario1(int ID, string nombre, string cantidad, int costou, int costot)
        {
            this.ID = ID;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.costou = costou;
            this.costot = costot;
        }
    }
}
