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
    public partial class Mision : Form
    {
        public Mision()
        {
            InitializeComponent();
        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            Inicio a = new Inicio();
            this.Hide();
            a.ShowDialog(); 
        }

        private void Btnmision_Click(object sender, EventArgs e)
        {
            label1.Text = "Nuestra misión es fomentar la pasión por el futbol \n" +
            "al proporcionar un entorno educativo de excelencia donde cada jugador,\n" +
            "independientemente de su nivel, pueda desarrollar sus habilidades técnicas,\n" +
            "tácticas y personales.";
        }
        private void Mision_Load(object sender, EventArgs e)
        {
            
        }
    }
}
