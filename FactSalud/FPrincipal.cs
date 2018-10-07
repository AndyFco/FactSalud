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
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void pediatriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir ventana consulta
            Consulta MenuP = new Consulta();
            MenuP.MdiParent = this;
            MenuP.WindowState = FormWindowState.Maximized;
            MenuP.Show();
        }

        private void psicologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir ventana consulta
            Consulta MenuP = new Consulta();
            MenuP.MdiParent = this;
            MenuP.WindowState = FormWindowState.Maximized;
            MenuP.Show();
        }

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir ventana laboratorio
            FLaboratorio MenuP = new FLaboratorio();
            MenuP.MdiParent = this;
            MenuP.WindowState = FormWindowState.Maximized;
            MenuP.Show();
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            ConecxionDB c = new ConecxionDB();
            c.Abrir();
       

        }
    }
}
