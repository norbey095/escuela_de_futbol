using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trabajo_final
{
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            Inicio a = new Inicio();
            this.Hide();
            a.ShowDialog();
        }        

        private void txtcedreg_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridmostrar.DataSource = datos_ingreso_operaciones.BuscarSolicitantes();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void txtcuibus_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptarS_Click(object sender, EventArgs e)
        {
            datos_ingreso datosformulario = new datos_ingreso();

            datosformulario.documento = Convert.ToInt32(txtcedbus.Text);
            datosformulario.tipo_documento = txtcuibus.Text;
            datosformulario.nombre = txtnombus.Text;
            datosformulario.apellido = txtapebus.Text;
            datosformulario.direccion = txtdirebus.Text;
            datosformulario.telefono = txttefebus.Text;
            datosformulario.fecha_nacimiento = textBox2.Text;
            datosformulario.observaciones = textBox1.Text;
            string estado = "A";
            datosformulario.estado =estado;

            int resultado = datos_ingreso_operaciones.AgregarSolicitud(datosformulario);

            if (resultado > 0)
            {
                MessageBox.Show("Solicitud Aceptada con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la solicitud", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRechazarS_Click(object sender, EventArgs e)
        {
            datos_ingreso datosformulario = new datos_ingreso();

            datosformulario.documento = Convert.ToInt32(txtcedbus.Text);
            datosformulario.tipo_documento = txtcuibus.Text;
            datosformulario.nombre = txtnombus.Text;
            datosformulario.apellido = txtapebus.Text;
            datosformulario.direccion = txtdirebus.Text;
            datosformulario.telefono = txttefebus.Text;
            datosformulario.fecha_nacimiento = textBox2.Text;
            datosformulario.observaciones = textBox1.Text;
            datosformulario.estado = "R";

            int resultado = datos_ingreso_operaciones.AgregarSolicitud(datosformulario);

            if (resultado > 0)
            {
                MessageBox.Show("Solicitud Rechazada con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la solicitud", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegresarS_Click(object sender, EventArgs e)
        {
            menu_loguin a = new menu_loguin();
            this.Hide(); 
            a.ShowDialog();
        }

        private void btnSalirS_Click(object sender, EventArgs e)
        {

        }

        private void dataGridmostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            string documento = txtcedbus.Text;
            List<datos_ingreso> resultado = datos_ingreso_operaciones.BuscarSolicitante(documento);
            txtnombus.Text = resultado[0].nombre;
            txtapebus.Text = resultado[0].apellido;
            txtdirebus.Text = resultado[0].direccion;
            txttefebus.Text = resultado[0].telefono;
            txtcuibus.Text = resultado[0].tipo_documento;
            textBox2.Text = resultado[0].fecha_nacimiento;
            textBox1.Text = resultado[0].observaciones;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
