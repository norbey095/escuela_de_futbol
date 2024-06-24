using MySql.Data.MySqlClient;
using System;

using System.Data;
using System.Windows.Forms;

namespace trabajo_final
{
    public partial class Mensualidades : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;
        public Mensualidades()
        {
            InitializeComponent();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
        private bool openConnection()
        {

            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                {
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("No se puede conectar con el servidor");
                            break;
                        case 1045:
                            MessageBox.Show("intente de nuevo");
                            break;
                        default:
                            MessageBox.Show(ex.Message);
                            break;
                    }
                    return false;
                    {


                    }
                }
            }

        }
        private bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btnRegresarmen_Click(object sender, EventArgs e)
        {
            menu_loguin a = new menu_loguin();
            this.Hide();
            a.ShowDialog();
        }

        private void Btnregistrar1_Click(object sender, EventArgs e)
        {
            mensualidad pago = new mensualidad();
            pago.identificacion = Convert.ToInt32(txtidentmen.Text);
            pago.nombre = txtnommen.Text.Trim();
            pago.mes = txtmesmen.Text.Trim();
            pago.valor = txtvalormen.Text.Trim();

            int resultado = datos_ingreso_operaciones.AgregarMensualidad(pago);
            if (resultado > 0)
            {
                MessageBox.Show("Mensualidad guardad con exito", "quedo almacenado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("no se pudo guardar", "falto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridmostrar.DataSource = datos_ingreso_operaciones.BuscarMensualidades();
        }
    }
}