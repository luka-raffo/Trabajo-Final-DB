using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DatosUsuario
    {

        public String DbConnection = "Data Source=localhost\\sqlexpress; Initial Catalog=Odontologia;Integrated Security=True";

        public DataTable ListarUsuarios(string query, SqlParameter parametro = null)
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


        public void InsertarUsuario(Usuario usu, string query)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                SqlCommand comando = new SqlCommand(query, conn);
                comando.Parameters.AddWithValue("@nombre", usu.nombre);
                comando.Parameters.AddWithValue("@contrasenia", usu.contrasenia);
                

                conn.Open();
                comando.ExecuteNonQuery();
            }
        }


    }
}
