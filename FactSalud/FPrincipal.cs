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
        }

        private void PsicologiaMenu(object sender, EventArgs e)
        {
            //Abrir ventana consulta
            Consulta MenuP = new Consulta();
            MenuP.MdiParent = this;
            MenuP.WindowState = FormWindowState.Maximized;
            MenuP.Show();
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
            ConecxionDB c = new ConecxionDB();
            c.Abrir();
            c.LlenarBoxGral(MedicoGralBox);
            c.LlenarGinecologia(GinecologiaBox);
            c.LlenarGinecologia(GinecologiaBox2);
            c.LlenarGinecologia(GinecologiaBox3);
        }

        private void MedicoGralBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int indice = MedicoGralBox.SelectedIndex;
            string seleccion =MedicoGralBox.Items[indice].ToString();
            //Abrir ventana consulta
            Consulta MenuP = new Consulta();
            MenuP.MdiParent = this;
            MenuP.WindowState = FormWindowState.Maximized;
            MenuP.Show();
            MenuP.ObtenerDoctor(seleccion);
         
        }
    }
}
