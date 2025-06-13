using Entidades;
using Negocio;
using Negocio.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBTP.Usuarios
{
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar0_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtContraseniaUsuario.Text))
            {
                lblMensaje.Text = "Por favor, completá todos los campos.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }





            Usuario usu = new Usuario(txtNombreUsuario.Text, txtContraseniaUsuario.Text);

            NegocioUsuario negocio = new NegocioUsuario();

            negocio.AgregarUsuario(usu);


            lblMensaje.Text = "Usuario " + txtNombreUsuario.Text + " ingresado exitosamente!";
            lblMensaje.ForeColor = System.Drawing.Color.Green;

        }
    }
}