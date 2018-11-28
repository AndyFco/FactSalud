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

        private void PediatriaMenu(object sender, EventArgs e)
        {
            //Abrir ventana consulta
            Consulta MenuP = new Consulta();
            MenuP.MdiParent = this;
            MenuP.WindowState = FormWindowState.Maximized;
            MenuP.Show();
            MenuP.ConsPediatria();

        }

        private void PsicologiaMenu(object sender, EventArgs e)
        {
            //Abrir ventana consulta
            Consulta MenuP = new Consulta();
            MenuP.MdiParent = this;
            MenuP.WindowState = FormWindowState.Maximized;
            MenuP.Show();
            MenuP.ConsPsicologia();
        }

        private void LaboratorioMenu(object sender, EventArgs e)
        {
            //Abrir ventana laboratorio
            FLaboratorio MenuP = new FLaboratorio();
            MenuP.MdiParent = this;
            MenuP.WindowState = FormWindowState.Maximized;
            MenuP.Show();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void medicinaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir ventana consulta
           
            Consulta MenuP = new Consulta();
            MenuP.MdiParent = this;
            MenuP.WindowState = FormWindowState.Maximized;
            MenuP.Show();
            MenuP.ConsGeneral();
        }

        private void ginecologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta MenuP = new Consulta();
            MenuP.MdiParent = this;
            MenuP.WindowState = FormWindowState.Maximized;
            MenuP.Show();
            MenuP.ConsGinecologia();
        }

        private void sonografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSonografia MenuP = new FSonografia();
            MenuP.MdiParent = this;
            MenuP.WindowState = FormWindowState.Maximized;
            MenuP.Show();
        }
    }
}
