using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoCajero
{
    public partial class Login : System.Web.UI.Page
    {
        private const int contador = 3;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Inicializa el contador de intentos fallidos
                Session["contIntentos"] = 0;
            }
        }

        protected void inicioSesion_Click1(object sender, EventArgs e)
        {
            // Comprueba si el contador de intentos fallidos ha alcanzado el máximo permitido
            if ((int)Session["contIntentos"] >= contador)
            {
                lblError.Text = "*Cuenta bloqueada por 24h, comunicate con el banco";
                lblError.CssClass = "mensaje__error--clave";
                lblError.ForeColor = System.Drawing.Color.DarkRed;
                return;
            }

            if (Session["Usuario"] != null)
            {
                Usuario cliente = (Usuario)Session["Usuario"];

                string user = txtUsuario.Text;
                string clave = txtClave.Text;

                if (cliente != null && cliente.User == user && cliente.Password == clave)
                {
                    // Reinicia el contador de intentos fallidos en caso de éxito
                    Session["contIntentos"] = 0;
                    Response.Redirect("Sesion-Activa.aspx");
                }
                else
                {
                    // Incrementa el contador de intentos fallidos
                    Session["contIntentos"] = (int)Session["contIntentos"] + 1;
                    lblError.Text = $"Usuario o clave incorrectos. Intento {Session["contIntentos"]} de {contador}.";
                    lblError.CssClass = "mensaje__error--clave";
                    lblError.ForeColor = System.Drawing.Color.DarkRed;

                    // Bloquea la cuenta si se alcanza el máximo de intentos
                    if ((int)Session["contIntentos"] >= contador)
                    {
                        lblError.Text = "Has alcanzado el número máximo de intentos. La cuenta está bloqueada.";
                        lblError.ForeColor = System.Drawing.Color.DarkRed;
                    }
                }
            }
            else
            {
                lblError.Text = "*Las claves no coinciden";
                lblError.CssClass = "mensaje__error--clave";
                lblError.ForeColor = System.Drawing.Color.DarkRed;
            }
        }
    }
}