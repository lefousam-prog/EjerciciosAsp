<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ejercicio5.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leer Notas</title>
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="form-group">
                <label for="txtNombre">Alumno</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtE1">E1</label>
                <asp:TextBox ID="txtE1" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtE2">E2</label>
                <asp:TextBox ID="txtE2" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtE3">E3</label>
                <asp:TextBox ID="txtE3" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtE4">E4</label>
                <asp:TextBox ID="txtE4" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtE5">E5</label>
                <asp:TextBox ID="txtE5" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="text-center">
                <asp:Button ID="btnCalcular" runat="server" Text="Calcular" CssClass="btn btn-primary" OnClick="btnCalcular_Click" />
            </div>
        </div>

        <!-- Modal para mostrar el promedio -->
        <div id="modalPromedio" class="modal">
            <div class="modal-header">
                <h4>Promedio</h4>
            </div>
            <div class="modal-body">
                <asp:Label ID="lblPromedio" runat="server" Text="Promedio"></asp:Label>
            </div>
            <div class="modal-footer">
                <button type="button" onclick="cerrarModal()">Cerrar</button>
            </div>
        </div>
        <div id="modalBackdrop" class="modal-backdrop"></div>

        <script type="text/javascript">
            // Función para mostrar el modal
            function mostrarModal() {
                document.getElementById('modalPromedio').style.display = 'block';
                document.getElementById('modalBackdrop').style.display = 'block';
            }

            // Función para cerrar el modal
            function cerrarModal() {
                document.getElementById('modalPromedio').style.display = 'none';
                document.getElementById('modalBackdrop').style.display = 'none';
            }
        </script>
    </form>
</body>
</html>
