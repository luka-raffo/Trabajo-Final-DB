using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioOdontologo
    {

        public DataTable ListarOdontologos()
        {
            DBRepository db = new DBRepository();
            string query = "SELECT odonto.ID_Odontologo AS [Id], " +
                            "odonto.Nombre AS [Nombre], odonto.DNI AS [DNI]," +
                            " odonto.FechaNac AS [FechaNac], odonto.sexo AS [Sexo] " +
                           "FROM Odontologo odonto ";

            return db.ListarOdontologos(query);
        }

    }
}
