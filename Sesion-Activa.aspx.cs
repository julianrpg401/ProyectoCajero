using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoCajero
{
    public partial class Sesion_Activa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void retirar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Retirar.aspx");
        }

        protected void consignar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consignar.aspx");
        }

        protected void consultarSaldo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consultar-Saldo.aspx");
        }

        protected void consultarMovimientos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consultar-Movimientos.aspx");
        }

        protected void cerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}