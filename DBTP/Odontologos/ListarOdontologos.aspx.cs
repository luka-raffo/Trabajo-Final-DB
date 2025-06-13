using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBTP
{
    public partial class ListarOdontologos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                NegocioOdontologo negocio = new NegocioOdontologo();
                GridViewListar.DataSource = negocio.ListarOdontologos();
                GridViewListar.DataBind();
            }

        }

        
    }
}