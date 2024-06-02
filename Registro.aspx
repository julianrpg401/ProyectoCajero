<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="ProyectoCajero.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="Styles.css" rel="stylesheet" />
    <title>Registro</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container container__registro">
            <div class="seccion__left">
                <figure class="container__figura">
                    <img src="Assets\Img\e8ba114121c8940c63a7d74990483cb0.png" alt="logo-bancolombia" class="container__imagen" />
                </figure>
                <h5 class="titulo">CREA TU CUENTA</h5>
            </div>

            <div class="seccion__right">
                <label for="txtName" class="nombre__campo">Nombre</label>
                <asp:TextBox ID="txtName" runat="server" CssClass="campo"></asp:TextBox>

                <label for="txtUser" class="nombre__campo">Usuario</label>
                <asp:TextBox ID="txtUser" runat="server" CssClass="campo"></asp:TextBox>

                <label for="txtId" class="nombre__campo">Identificación</label>
                <asp:TextBox ID="txtId" runat="server" CssClass="campo"></asp:TextBox>

                <label for="txtEmail" class="nombre__campo">Email</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="campo"></asp:TextBox>

                <label for="txtPassword" class="nombre__campo">Clave</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="campo"></asp:TextBox>

                <label for="txtPasswordChecker" class="nombre__campo">Confirmar clave</label>
                <asp:TextBox ID="txtPasswordChecker" runat="server" TextMode="Password" CssClass="campo"></asp:TextBox>

                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>

                <asp:LinkButton ID="inicioSesion" runat="server" OnClick="LinkButton1_Click" CssClass="boton">REGISTRARSE</asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
