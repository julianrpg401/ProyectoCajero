<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sesion-Activa.aspx.cs" Inherits="ProyectoCajero.Sesion_Activa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="Styles.css" rel="stylesheet" />
    <title>Cajero</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <figure class="container__figura">
                <img src="Assets\Img\e8ba114121c8940c63a7d74990483cb0.png" alt="" class="container__imagen" />
            </figure>
            <asp:LinkButton ID="retirar" runat="server" class="boton" OnClick="retirar_Click">RETIRAR</asp:LinkButton>
            <asp:LinkButton ID="consignar" runat="server" class="boton" OnClick="consignar_Click">CONSIGNAR</asp:LinkButton>
               
            <asp:LinkButton ID="consultarSaldo" runat="server" class="boton" OnClick="consultarSaldo_Click">CONSULTAR SALDO</asp:LinkButton>
            <asp:LinkButton ID="consultarMovimientos" runat="server" class="boton" OnClick="consultarMovimientos_Click">CONSULTAR MOVIMIENTOS</asp:LinkButton>
               
            <asp:LinkButton ID="cerrarSesion" runat="server" class="boton" OnClick="cerrarSesion_Click">SALIR</asp:LinkButton>
        </div>
    </form>
</body>
</html>
