<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultar-Saldo.aspx.cs" Inherits="ProyectoCajero.Consultar_Saldo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="Styles.css" rel="stylesheet" />
    <title>Saldo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <figure class="container__figura">
                <img src="Assets\Img\e8ba114121c8940c63a7d74990483cb0.png" alt="" class="container__imagen" />
            </figure>

            <asp:Label ID="txtSaldo" runat="server" Text="" CssClass="saldo__actual"></asp:Label>
        </div>
    </form>
</body>
</html>
