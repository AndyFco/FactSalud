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
        

        public void ConsGeneral()
        {

            ConecxionDB c = new ConecxionDB();
            c.Abrir();
            c.LlenarBoxGral(comboBoxMedico);
            comboConsulta.Items.Add("Consulta General");
            comboConsulta.Items.Add("Resultados");

        }
        public void ConsGinecologia()
        {

            ConecxionDB c = new ConecxionDB();
            c.Abrir();
            c.LlenarGinecologia(comboBoxMedico);
            comboConsulta.Items.Add("Consulta Ginecologica");
            comboConsulta.Items.Add("PAP");
            comboConsulta.Items.Add("Resultados");

        }
        public void ConsPediatria()
        {
            ConecxionDB c = new ConecxionDB();
            c.Abrir();
            c.LlenarPediatria(comboBoxMedico);
            comboConsulta.Items.Add("Consulta pediatria");
            comboConsulta.Items.Add("Resultados");

        }
        public void ConsPsicologia()
        {
            ConecxionDB c = new ConecxionDB();
            c.Abrir();
            c.LlenarPsicologia(comboBoxMedico);
            comboConsulta.Items.Add("Consulta psicologia");
            comboConsulta.Items.Add("Resultados");

        }


        private void BtnSalir(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ConecxionDB c = new ConecxionDB();
            c.EnviarPaciente(tBoxNombre.Text, tBoxDireccion.Text, tBoxTelefono.Text, int.Parse(tBoxEdad.Text), tBoxCedula.Text);
            this.Close();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            
        }
    }
}
