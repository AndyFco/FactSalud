using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactSalud
{
    public partial class FSonografia : Form
    {
        public FSonografia()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            ConecxionDB c = new ConecxionDB();
            c.EnviarPaciente(tBoxNombre.Text, tBoxDireccion.Text, tBoxTelefono.Text, int.Parse(tBoxEdad.Text), tBoxCedula.Text);
            this.Close();
        }
    }
}
