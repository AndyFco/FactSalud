using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace FactSalud
{
    class ConecxionDB
    {
        String cadena = "Data Source=DESKTOP-F2CCQD0\\SQLEXPRESS; initial Catalog=FactSalud; Integrated Security=True";
        public SqlConnection conectar = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;
        
        public ConecxionDB()
        {
            conectar.ConnectionString=cadena;
        }
      
        public void Abrir()
        {//Realiza conexion a la base de datos
            try
            {
                conectar.Open();
                Console.WriteLine("Exito");
            }
            catch(Exception ex)
            { Console.WriteLine("Error" + ex.Message); }
        }
        public void LlenarBoxGral(ToolStripComboBox cb)
        {//Selecciona de la base de datos quienes imparten medicina General
            try
            {
                cmd = new SqlCommand("SELECT MedicoNombre From Medico where MedicoEspecialidad ='Med. General' or MedicoEspecialidad ='Gineco Obstetra';", conectar);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["MedicoNombre"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }
        }
        public void LlenarGinecologia(ToolStripComboBox cb)
        {//Selecciona de la base de datos quienes imparten Ginecologia
            try
            {
                cmd = new SqlCommand("SELECT MedicoNombre From Medico where  MedicoEspecialidad ='Gineco Obstetra';", conectar);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["MedicoNombre"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }
        }
        public void LlenarLab(CheckedListBox cb)
        {//Selecciona de la base de datos los analisis registrados
            try
            {
                cmd = new SqlCommand("SELECT AnalisisDescripcion From Analisis;", conectar);//, AnalisisPrecio
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["AnalisisDescripcion"]);//+"  AnalisisPrecio"
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el List: " + ex.ToString());
            }
        }
        public void EnviarPaciente(string nombre,string direccion,string telefono, int edad,string cedula)
        {//Para enviar los datos del paciente
            try
            {

            String query = "INSERT INTO Paciente (PacienteNombre,PacienteDireccion,PacienteTelefono,PacienteEdad,PacienteCedula) VALUES (@nombre,@dir,@tel, @edad,@cedula)";

                using (SqlCommand command = new SqlCommand(query, conectar))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@dir", direccion);
                    command.Parameters.AddWithValue("@tel", telefono);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@cedula", cedula);

                    conectar.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se enviaron los datos " + ex.ToString());
            }
        }

    }
}
