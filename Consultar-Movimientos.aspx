<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultar-Movimientos.aspx.cs" Inherits="ProyectoCajero.Consultar_Movimientos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Styles.css" rel="stylesheet" />  
    <title>Movimientos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <figure class="container__figura">
                <img src="Assets\Img\e8ba114121c8940c63a7d74990483cb0.png" alt="" class="container__imagen" />
            </figure>
            <asp:GridView ID="gridMovimientos" runat="server" AutoGenerateColumns="False" CssClass="movimientos-table">
                <Columns>
                    <asp:BoundField DataField="Concepto" HeaderText="Concepto" />
                    <asp:BoundField DataField="Valor" HeaderText="Valor" />
                    <asp:BoundField DataField="Saldo" HeaderText="Saldo" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
