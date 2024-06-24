using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_final
{
    public partial class menu_loguin : Form
    {
        public menu_loguin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros a = new Registros();
            this.Hide();
            a.ShowDialog();
        }

        private void mensualidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mensualidades a = new Mensualidades();
            this.Hide(); 
            a.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario a = new Inventario();
            this.Hide(); 
            a.ShowDialog();
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nomina a = new Nomina();
            this.Hide(); 
            a.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio a = new Inicio();
            this.Hide();
            a.ShowDialog();
        }
    }
}
