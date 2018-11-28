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
    public partial class FAnalisis : Form
    {
        public FAnalisis()
        {
            InitializeComponent();
        }

        private void FAnalisis_Load(object sender, EventArgs e)
        {
            ConecxionDB c = new ConecxionDB();
            c.Abrir();
            c.LlenarLab(AnalisisLiBox);
        }
        public List<String> Analisis;
        public void Enviar()
        {


            Analisis.Add(AnalisisLiBox.SelectedItem.ToString());
            //Abrir ventana laboratorio
            FLaboratorio MenuP = new FLaboratorio();
            MenuP.MdiParent = this;
            MenuP.WindowState = FormWindowState.Maximized;
            MenuP.ObtenerAnalisis(Analisis); 
            MenuP.Show();

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            Enviar();
            this.Close();
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
