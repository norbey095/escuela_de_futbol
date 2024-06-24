using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_final
{
    internal class inicio_sesion
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        
        public inicio_sesion() { }
        public inicio_sesion(int id, string usuario, string contraseña)
        {
            this.id = id;
            this.usuario = usuario;
            this.contraseña = contraseña;
        }
    }
}
