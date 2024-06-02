<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoCajero.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="Styles.css" rel="stylesheet" />
    <title>Iniciar sesion</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="seccion__top--logo">
                <figure class="container__figura">
                    <img src="Assets\Img\e8ba114121c8940c63a7d74990483cb0.png" alt="logo-bancolombia" class="container__imagen" />
                </figure>
                <h5 class="titulo">INICIO DE SESION</h5>
            </div>
            <div class="seccion__bottom--form">
                <label for="txtUsuario" class="nombre__campo">Usuario</label>
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="campo"></asp:TextBox>

                <label for="txtClave" class="nombre__campo">Clave</label>
                <asp:TextBox ID="txtClave" runat="server" TextMode="Password" CssClass="campo campo--margen"></asp:TextBox>

                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>

                <asp:LinkButton ID="inicioSesion" runat="server" CssClass="boton__inicio--sesion" OnClick="inicioSesion_Click1">INICIAR SESION</asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
