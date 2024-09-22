<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ejercicio_6.Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <title>Ejercicio 6</title>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
    <style>
        .container {
            margin-top: 20px;
        }
        .number-image {
            width: 100px; /* Ajusta el tamaño de las imágenes según tus necesidades */
            cursor: pointer;
            margin: 5px;
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <script>
        function showMultiplicationTable(number) {
            var multiplicationList = "";

            for (var i = 1; i <= 10; i++) {
                multiplicationList += "<li class='list-group-item'>" + number + " x " + i + " = " + (number * i) + "</li>";
            }

            $('#modalTitle').text('Tabla de multiplicar del ' + number);
            $('#multiplicationList').html(multiplicationList);
            $('#multiplicationModal').modal('show');
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <div class="container">
            <h2 class="text-center">Tabla de Números</h2>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="row" runat="server" id="numberTable">
                        <!-- Las imágenes se generarán dinámicamente aquí -->
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

        <!-- Modal para mostrar la tabla de multiplicar -->
        <div class="modal fade" id="multiplicationModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="modalTitle">Tabla de Multiplicar</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <ul id="multiplicationList" class="list-group">
                            <!-- La tabla de multiplicar se llenará aquí -->
                        </ul>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
