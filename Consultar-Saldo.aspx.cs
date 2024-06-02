using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoCajero
{
    public partial class Consultar_Saldo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cuenta cuenta = (Cuenta)Session["Cuenta"];
            string saldo = cuenta.Saldo.ToString();

            txtSaldo.Text = $"Su saldo actual es ${saldo}";
        }
    }
}