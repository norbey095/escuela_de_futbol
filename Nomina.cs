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
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }

        private void btnRegresarnom_Click(object sender, EventArgs e)
        {
            menu_loguin a = new menu_loguin();
            this.Hide();
            a.ShowDialog();
        }

        private void Btnregistrar1_Click(object sender, EventArgs e)
        {
            nomina1 nomina = new nomina1();
            nomina.cedula = Convert.ToInt32(txtcedemp.Text);
            nomina.nombre = txtnomemp.Text.Trim();
            nomina.periodo = txtperio.Text.Trim();
            nomina.deduciones = txtdeduc.Text.Trim();
            nomina.total = txttotal.Text.Trim();

            int resultado = datos_ingreso_operaciones.AgregarNomina(nomina);
            if (resultado > 0)
            {
                MessageBox.Show("Nomina guardada con exito", "quedo almacenado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("no se pudo guardar", "falto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridmostrar.DataSource = datos_ingreso_operaciones.BuscarNomina();
        }

        private void Mostrar_cliente_Click(object sender, EventArgs e)
        {

        }
    }
}
