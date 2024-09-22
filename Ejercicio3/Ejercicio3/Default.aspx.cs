using System;
using System.Web.UI;

namespace Ejercicio3
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores ingresados
                double valorCompra = Convert.ToDouble(txtCompra.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                // Calcular el porcentaje de descuento según la cantidad
                double porcentajeDescuento = ObtenerDescuentoPorCantidad(cantidad);

                // Calcular el valor del descuento en dinero
                double descuentoDinero = valorCompra * (porcentajeDescuento / 100);

                // Calcular el total a pagar después del descuento
                double totalAPagar = valorCompra - descuentoDinero;

                // Mostrar los resultados en la página
                lblResultado.Text = $"Valor de la compra: {valorCompra:C}<br/>" +
                                    $"Cantidad: {cantidad}<br/>" +
                                    $"Descuento aplicado: {porcentajeDescuento}%<br/>" +
                                    $"Valor del descuento: {descuentoDinero:C}<br/>" +
                                    $"Total a pagar: {totalAPagar:C}";
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si los datos ingresados no son válidos
                lblResultado.Text = "Por favor, ingresa valores numéricos válidos para la compra y la cantidad.";
            }
        }

        // Método para obtener el porcentaje de descuento según la cantidad
        private double ObtenerDescuentoPorCantidad(int cantidad)
        {
            if (cantidad >= 1 && cantidad <= 5)
            {
                return 10.0;
            }
            else if (cantidad >= 6 && cantidad <= 10)
            {
                return 20.0;
            }
            else if (cantidad >= 11 && cantidad <= 15)
            {
                return 30.0;
            }
            else if (cantidad >= 16 && cantidad <= 20)
            {
                return 40.0;
            }
            else if (cantidad >= 21)
            {
                return 50.0;
            }
            else
            {
                return 0.0; // Sin descuento si la cantidad es menor a 1
            }
        }
    }
}
