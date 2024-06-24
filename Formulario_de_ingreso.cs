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
    public partial class Formulario_de_ingreso : Form
    {
        string estado = "S";
        public Formulario_de_ingreso()
        {
            InitializeComponent();
        }

        private void Btnenviar_Click(object sender, EventArgs e)
        {
            datos_ingreso datosformulario = new datos_ingreso();

            datosformulario.documento = Convert.ToInt32(txtnumefor.Text);
            datosformulario.tipo_documento = comboBox1.Text;
            datosformulario.nombre = txtnomfor.Text;
            datosformulario.apellido = txtapellfor.Text;
            datosformulario.direccion = txtdirecfor.Text;
            datosformulario.telefono = txttelfor.Text;
            datosformulario.fecha_nacimiento = txtfechfor.Text;
            datosformulario.observaciones = txtobserfor.Text;
            datosformulario.estado = "estado";

            int resultado = datos_ingreso_operaciones.AgregarSolicitud(datosformulario);

            if (resultado > 0)
            {
                MessageBox.Show("Solicitud Guardada con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la solicitud", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtnumefor.Text = "";
            comboBox1.Text = "";
            txtnomfor.Text = "";
            txtapellfor.Text = "";
            txtdirecfor.Text = "";
            txttelfor.Text = "";
            txtfechfor.Text = "";
            txtobserfor.Text = "";
        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            Inicio a = new Inicio();
            this.Hide();
            a.ShowDialog();
        }

        private void Formulario_de_ingreso_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtobserfor_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
