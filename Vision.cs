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
    public partial class Vision : Form
    {
        public Vision()
        {
            InitializeComponent();
        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            Inicio a = new Inicio();
            this.Hide();
            a.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btnvision_Click(object sender, EventArgs e)
        {
            label1.Text = "Ser la principal escuela de futbol reconocida por su compromiso con el desarrollo\n" +
                "integral de jóvenes futbolistas, ofreciendo un ambiente de aprendizaje innovador,\n" +
                "valores sólidos y oportunidades de crecimiento, convirtiéndonos en un referente\n" +
                "que inspira pasión por el juego y forja campeones tanto dentro como fuera del campo.";
        }
    }
}
