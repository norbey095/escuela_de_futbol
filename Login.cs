using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace trabajo_final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio a = new Inicio();
            this.Hide();
            a.ShowDialog();
        }

        private void Btningresar_Click(object sender, EventArgs e)
        {
            string query = "SELECT count(*) FROM inicio_sesion where usuario = '{0}' AND contrasena = '{1}'";
            MySqlCommand comando = new MySqlCommand(string.Format(query, txtusuario.Text, txtclave.Text), bdcomun.obtenerconexion());

            int cant = System.Convert.ToInt32(comando.ExecuteScalar());

            if (cant > 0)
            {
                menu_loguin frm = new menu_loguin();
                Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("usuario o clave incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtclave.Text = "";
                txtusuario.Text = "";
                txtusuario.Focus();
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu_loguin a = new menu_loguin();
            this.Hide();
            a.ShowDialog();
        }
    }
    
}
