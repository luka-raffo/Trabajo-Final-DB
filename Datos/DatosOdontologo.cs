using System;
using Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Datos
{

    public class DatosOdontologo
    {
        public String DbConnection = "Data Source=localhost\\sqlexpress; Initial Catalog=Odontologia;Integrated Security=True";

        public DataTable ListarOdontologos(string query, SqlParameter parametro = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(DbConnection))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parametro != null)
                {
                    cmd.Parameters.Add(parametro);
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }


        public void InsertarOdontologo(Odontologo odonto, string query)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                SqlCommand comando = new SqlCommand(query, conn);
                comando.Parameters.AddWithValue("@especialidad", odonto.especialidad);
                comando.Parameters.AddWithValue("@dni", odonto.dni);
                comando.Parameters.AddWithValue("@nombre", odonto.nombre);
                comando.Parameters.AddWithValue("@apellido", odonto.apellido);
                comando.Parameters.AddWithValue("@telefono", odonto.telefono);
                comando.Parameters.AddWithValue("@direccion", odonto.direccion);
                comando.Parameters.AddWithValue("@fechaNac", odonto.fechaNac);
                comando.Parameters.AddWithValue("@sexo", odonto.sexo);
                
                
                conn.Open();
                comando.ExecuteNonQuery();
            }
        }



        public void TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection))
                {
                    conn.Open();
                    Console.WriteLine("conexion exitosa");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error de conexion");
            }
        }

    }
}
