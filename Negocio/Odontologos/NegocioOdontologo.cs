using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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
                            "odonto.Apellido AS [Apellido], odonto.Telefono AS [Telefono], odonto.Direccion AS [Direccion]," +
                            " odonto.Fecha_Nac AS [FechaNac], odonto.sexo AS [Sexo] " +

                           "FROM Odontologo odonto ";

            db.TestConnection();

            return db.ListarOdontologos(query);
        }

        public void AgregarOdontologo(Odontologo odonto)
        {
            string query = "INSERT INTO Odontologo (Especialidad, DNI, Nombre, Apellido, Telefono, Direccion, Fecha_Nac, sexo) " +
                         "VALUES (@especialidad, @dni, @nombre, @apellido, @telefono, @direccion, @fechaNac, @sexo)";
            DatosOdontologo dbRepository = new DatosOdontologo();
            dbRepository.InsertarOdontologo(odonto, query);
            

        }
    }
}
