using Datos;
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
            DatosOdontologo db = new DatosOdontologo();
            string query = "SELECT odonto.ID_Odontologo AS [Id], " +
                            "odonto.Nombre AS [Nombre], odonto.DNI AS [DNI]," +
                            " odonto.Fecha_Nac AS [FechaNac], odonto.sexo AS [Sexo] " +
                           "FROM Odontologo odonto ";

            db.TestConnection();

            return db.ListarOdontologos(query);
        }

    }
}
