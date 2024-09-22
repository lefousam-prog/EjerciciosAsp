<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ejercicio3.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calcular Descuento</title>
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <h2 class="text-center">Registro de Compra</h2>
            <div class="form-group">
                <label for="txtCompra">Valor de la Compra:</label>
                <asp:TextBox ID="txtCompra" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtCantidad">Cantidad:</label>
                <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="text-center">
                <asp:Button ID="btnCalcular" runat="server" Text="Calcular" CssClass="btn btn-primary" OnClick="btnCalcular_Click" />
            </div>

            <!-- Resultados -->
            <div class="resultado text-center">
                <asp:Label ID="lblResultado" runat="server" CssClass="resultado-text"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
