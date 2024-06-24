using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_final
{
    internal class datos_ingreso
    {
        public int documento { get; set; }
        public string tipo_documento { get; set; }
        public string nombre { get; set; }
        public string apellido{ get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string fecha_nacimiento { get; set; }
        public string observaciones { get; set; }
        public string estado { get; set; }

        public datos_ingreso() { }
        public datos_ingreso(int documento, string tipo_documento, string nombre, string apellido, string direccion, string telefono,
            string fecha_nacimiento, string observaciones,string estado)
        {
            this.documento = documento;
            this.tipo_documento = tipo_documento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.fecha_nacimiento = fecha_nacimiento;
            this.observaciones = observaciones;
            this.estado = estado;
        }
    }
}
