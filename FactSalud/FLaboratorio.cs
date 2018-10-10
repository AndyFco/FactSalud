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
    public partial class FLaboratorio : Form
    {
        public FLaboratorio()
        {
            InitializeComponent();
        }

        private void BtnSalir(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FLaboratorio_Load(object sender, EventArgs e)
        {
         
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FAnalisis A = new FAnalisis();
            A.Show();
        }
    }
}

