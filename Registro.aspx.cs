using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoCajero
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordChecker.Text)
            {
                lblError.Text = "*Las claves no coinciden";
                lblError.CssClass = "mensaje__error--clave";
                lblError.ForeColor = System.Drawing.Color.DarkRed;
            }
            else
            {
                // Se Crea el objeto cliente y se llenan sus propiedades
                Usuario cliente = new Usuario();
                cliente.Name = txtName.Text;
                cliente.User = txtUser.Text;
                cliente.Id = uint.Parse(txtId.Text);
                cliente.Email = txtEmail.Text;
                cliente.Password = txtPassword.Text;

                // Se crea el objeto cuenta y se llenan sus propiedades
                Cuenta cuenta = new Cuenta();
                cuenta.NumCuenta = 3112154098;
                cuenta.Id = cliente.Id;
                cuenta.Saldo = 5000000;
                

                // Se guarda el objeto cliente y cuenta en la sesión para poder accederlo desde otro Web Form
                Session["Usuario"] = cliente;
                Session["Cuenta"] = cuenta;

                // Redirigir a otro Web Form
                Response.Redirect("Login.aspx");
            }
        }
    }
}