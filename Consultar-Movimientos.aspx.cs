using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoCajero
{
    public partial class Consultar_Movimientos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cuenta cuenta = (Cuenta)Session["Cuenta"];
                gridMovimientos.DataSource = cuenta.Movimientos;
                gridMovimientos.DataBind();
            }
        }
    }
}