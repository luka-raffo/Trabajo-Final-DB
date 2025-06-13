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
    public partial class ListarUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NegocioUsuario negocio = new NegocioUsuario();
                GridViewListar.DataSource = negocio.ListarUsuarios();
                GridViewListar.DataBind();
            }
        }
    }
}