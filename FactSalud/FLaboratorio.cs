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
            llenar();
        }

        public List<string> numeros = new List<string>();

        public void llenar()
        {
            //Añades los números
            this.numeros.Add(" fff");
            this.numeros.Add(" fff");
            this.numeros.Add(" fff");
            this.numeros.Add(" fff");
            this.numeros.Add(" fff");


            //Eliminas números duplicados y llenas el listbox
            listBox1.Items.Add(numeros);
        }

        private void BtnSalir(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

