<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consignar.aspx.cs" Inherits="ProyectoCajero.Consignar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="Styles.css" rel="stylesheet" /> 
    <title>Consignar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <figure class="container__figura">
                <img src="Assets\Img\e8ba114121c8940c63a7d74990483cb0.png" alt="" class="container__imagen" />
            </figure>

            <label for="txtConsignar" class="nombre__campo">Ingrese el monto a consignar</label>
            <asp:TextBox ID="txtConsignar" runat="server" CssClass="campo campo--margen"></asp:TextBox>

            <asp:Label ID="mensajeConsignar" runat="server" Text="" CssClass="mensaje"></asp:Label>

            <asp:Button ID="botonConsignar" runat="server" Text="CONSIGNAR" OnClick="botonConsignar_Click" CssClass="boton" />
            <asp:LinkButton ID="botonRegresar" runat="server" OnClick="botonRegresar_Click" CssClass="boton">REGRESAR</asp:LinkButton>
        </div>
    </form>
</body>
</html>
