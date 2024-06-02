<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ProyectoCajero.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="Styles.css" rel="stylesheet" />
    <title>Cajero Bancolombia</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <figure class="container__figura">
                <img src="Assets\Img\e8ba114121c8940c63a7d74990483cb0.png" alt="" class="container__imagen" />
            </figure>
            <div class="botones">
                <asp:LinkButton ID="boton_registro" runat="server" class="boton" href="Registro.aspx">REGISTRATE</asp:LinkButton>
                <asp:LinkButton ID="boton_inicio_sesion" runat="server" class="boton" href="Login.aspx">INICIAR SESION</asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
