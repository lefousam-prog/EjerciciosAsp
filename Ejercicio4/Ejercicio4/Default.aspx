<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ejercicio4.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Compras</title>
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <h2 class="text-center">Registro de Compras</h2>
            <div class="form-group">
                <label for="txtZapatos">Costo de Zapatos:</label>
                <asp:TextBox ID="txtZapatos" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtCamiseta">Costo de Camiseta:</label>
                <asp:TextBox ID="txtCamiseta" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPantalones">Costo de Pantalones:</label>
                <asp:TextBox ID="txtPantalones" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="text-center">
                <asp:Button ID="btnPagar" runat="server" Text="Pagar" CssClass="btn btn-primary" OnClick="btnPagar_Click" />
            </div>

            <!-- Resultados -->
            <div class="resultado text-center">
                <asp:Label ID="lblResultado" runat="server" CssClass="resultado-text"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
