using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Usuarios
{
    public class NegocioUsuario
    {
        public DataTable ListarUsuarios()
        {
            DatosUsuario db = new DatosUsuario();
            string query = "SELECT usu.ID_Usuario AS [Id], " +
                            "usu.Nombre_Usuario AS [Nombre], usu.Contraseña AS [Contraseña] " +
                            
                           "FROM Usuario usu ";

            

            return db.ListarUsuarios(query);
        }


        public void AgregarUsuario(Usuario usu)
        {
            string query = "INSERT INTO Usuario (Nombre_Usuario, Contraseña)" +
                         "VALUES (@nombre, @contrasenia)";
            DatosUsuario dbRepository = new DatosUsuario();
            dbRepository.InsertarUsuario(usu, query);

        }

        }
}
