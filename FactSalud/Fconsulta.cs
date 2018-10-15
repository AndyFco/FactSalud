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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void ObtenerDoctor( string n)
        {
            lblMedico.Text = n;
        }
        private void BtnSalir(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
