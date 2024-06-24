using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trabajo_final
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void txttelreg1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Btnmodificar11_Click(object sender, EventArgs e)
        {
            Inventario1 inventario = new Inventario1();
            inventario.ID = Convert.ToInt32(txtcedmodi11.Text);
            inventario.nombre = txtnommodi11.Text.Trim();
            inventario.cantidad = txtapemodi11.Text.Trim();
            inventario.costou = Convert.ToInt32(txtdiremodi11.Text.Trim());
            inventario.costot = Convert.ToInt32(txtdirereg1.Text.Trim()) * Convert.ToInt32(txtapereg1.Text.Trim());

            int resultado = datos_ingreso_operaciones.ModificarInventario(inventario);
            if (resultado > 0)
            {
                MessageBox.Show("Inventario actualizado con exito", "quedo almacenado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("no se pudo guardar", "falto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarinv_Click(object sender, EventArgs e)
        {
            menu_loguin a = new menu_loguin();
            this.Hide();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridmostrar.DataSource = datos_ingreso_operaciones.MostrarProductos();
        }

        private void Btnregistrar1_Click(object sender, EventArgs e)
        {
            Inventario1 inventario = new Inventario1();
            inventario.ID = Convert.ToInt32(txtcedreg1.Text);
            inventario.nombre = txtnomreg1.Text.Trim();
            inventario.cantidad = txtapereg1.Text.Trim();
            inventario.costou = Convert.ToInt32(txtdirereg1.Text.Trim());
            inventario.costot = Convert.ToInt32(txtdirereg1.Text.Trim()) * Convert.ToInt32(txtapereg1.Text.Trim());
            lblcostototalInv.Text = Convert.ToString(inventario.costot);

            int resultado = datos_ingreso_operaciones.AgregarInventario(inventario);
            if (resultado > 0)
            {
                MessageBox.Show("Inventario guardado con exito", "quedo almacenado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("no se pudo guardar", "falto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button111_Click(object sender, EventArgs e)
        {
            string documento = txtcedmodi11.Text;
            List<Inventario1> resultado = datos_ingreso_operaciones.BuscarInventario(documento);
            txtnommodi11.Text = resultado[0].nombre;
            txtapemodi11.Text = resultado[0].cantidad;
            txtdiremodi11.Text = Convert.ToString(resultado[0].costou);           
        }

        private void Btninhab1_Click(object sender, EventArgs e)
        {
            datos_ingreso_operaciones.EliminarProducto(txtcedinha1.Text);
            dataGridView21.DataSource = datos_ingreso_operaciones.MostrarProductos();
        }
    }
}
