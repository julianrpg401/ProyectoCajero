using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoCajero
{
    public partial class Consignar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonConsignar_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtConsignar.Text);
            Cuenta cuenta = (Cuenta)Session["Cuenta"]; // Recuperamos el objeto de la sesion

            if (monto > 0)
            {
                cuenta.Consignar(monto); // Invocamos el método
                mensajeConsignar.Text = $"Consignación exitosa, su nuevo saldo es de ${cuenta.Saldo}";
            }
            else
            {
                mensajeConsignar.Text = "Ingrese un monto válido";
            }
        }

        protected void botonRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sesion-Activa.aspx");
        }
    }
}