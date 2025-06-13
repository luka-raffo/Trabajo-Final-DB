using Negocio;
using System;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio.Usuarios;
using System.Data;

namespace DBTP
{
    public partial class AñadirOdontologo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAceptar0_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(txtNombreOdontologo.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(TextBoxDNI.Text) || string.IsNullOrEmpty(TextBoxTelefono.Text) || string.IsNullOrEmpty(TextBoxDireccion.Text) || string.IsNullOrEmpty(txtFechaNac.Text))
            {
                lblMensaje.Text = "Por favor, completá todos los campos.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }


            NegocioOdontologo negocio = new NegocioOdontologo();

           

            

            

            

            
            

                

               

                



                Odontologo odonto = new Odontologo(

            int.Parse(TextBoxDNI.Text),
            txtNombreOdontologo.Text,
            txtApellido.Text,
            TextBoxEspecialidad.Text,
            TextBoxTelefono.Text,
            TextBoxDireccion.Text,
            txtFechaNac.Text,
            rblSexo.Text
            
     
        );
           
            
            negocio.AgregarOdontologo(odonto);


            lblMensaje.Text = "Odontologo " + txtNombreOdontologo.Text + " ingresado exitosamente!";
            lblMensaje.ForeColor = System.Drawing.Color.Green;

            
        }

        public List<Usuario> ObtenerUsuarios()
        {
            NegocioUsuario negocio = new NegocioUsuario();
            DataTable tablaUsuarios = negocio.ListarUsuarios();

            if (tablaUsuarios.Rows.Count == 0)
            {
                // Validación simple para asegurarte de que está llegando algo
                throw new Exception("No se encontraron usuarios en la base de datos.");
            }

            List<Usuario> usuarios = new List<Usuario>();

            foreach (DataRow row in tablaUsuarios.Rows)
            {
                usuarios.Add(new Usuario
                {
                    nombre = row["Nombre"].ToString(),
                    contrasenia = row["Contraseña"].ToString()

                });
            }

            return usuarios;
        }


        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}