using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FactSalud
{
    class ConecxionDB
    {
        String cadena = "Data Source=DESKTOP-F2CCQD0\\SQLEXPRESS; initial Catalog=FactSalud; Integrated Security=True";
        public SqlConnection conectar = new SqlConnection();

        //en el constructor
        public ConecxionDB()
        {
            conectar.ConnectionString=cadena;
        }
        

        public void Abrir()
        {
            try
            {
                conectar.Open();
                Console.WriteLine("Exito");
            }
            catch(Exception ex)
            { Console.WriteLine("Error" + ex.Message); }
        }

    }
}
