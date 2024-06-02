using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoCajero
{
    public partial class Retirar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonRetirar_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtRetirar.Text);
            Cuenta cuenta = (Cuenta)Session["Cuenta"]; // Recuperamos el objeto de la sesion

            if (monto > 0 && monto <= cuenta.Saldo) // Validamos que el monto a retirar sea menor que el saldo
            {
                cuenta.Retirar(monto); // Invocamos el método
                mensajeRetiro.Text = $"Retiro exitoso, su nuevo saldo es de ${cuenta.Saldo}";
            }
            else if (monto > cuenta.Saldo)
            {
                mensajeRetiro.Text = "El valor del retiro no puede ser mayor al saldo";
            }
            else
            {
                mensajeRetiro.Text = "El valor del retiro no puede ser negativo";
            }
            
        }

        protected void botonRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sesion-Activa.aspx");
        }
    }
}