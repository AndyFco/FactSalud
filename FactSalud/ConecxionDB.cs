﻿using System;
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }
        }

    }
}
