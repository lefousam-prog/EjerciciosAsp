<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ejercicio1.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calcular Salario Neto</title>
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <h2 class="text-center">Calcular Salario Neto</h2>
            <div class="form-group">
                <label for="txtSalarioBase">Salario Base:</label>
                <asp:TextBox ID="txtSalarioBase" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="text-center">
                <asp:Button ID="btnCalcularSalario" runat="server" Text="Calcular Salario Neto" CssClass="btn btn-primary" OnClick="btnCalcularSalario_Click" />
            </div>

            <!-- Resultados -->
            <div class="resultado text-center">
                <asp:Label ID="lblResultado" runat="server" CssClass="resultado-text"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
