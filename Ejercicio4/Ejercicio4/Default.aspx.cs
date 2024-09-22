using System;
using System.Web.UI;

namespace Ejercicio4
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los costos de los productos ingresados
                double costoZapatos = Convert.ToDouble(txtZapatos.Text);
                double costoCamiseta = Convert.ToDouble(txtCamiseta.Text);
                double costoPantalones = Convert.ToDouble(txtPantalones.Text);

                // Calcular el total de la compra
                double totalCompra = costoZapatos + costoCamiseta + costoPantalones;

                // Determinar el porcentaje de descuento
                double porcentajeDescuento = ObtenerDescuento(totalCompra);

                // Calcular el valor del descuento en dinero
                double descuentoDinero = totalCompra * (porcentajeDescuento / 100);

                // Calcular el total a pagar después del descuento
                double totalAPagar = totalCompra - descuentoDinero;

                // Mostrar los resultados en la página
                lblResultado.Text = $"Total de la compra: {totalCompra:C}<br/>" +
                                    $"Descuento aplicado: {porcentajeDescuento}%<br/>" +
                                    $"Valor del descuento: {descuentoDinero:C}<br/>" +
                                    $"Total a pagar: {totalAPagar:C}";
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si los datos ingresados no son válidos
                lblResultado.Text = "Por favor, ingresa valores numéricos válidos para los costos.";
            }
        }

        // Método para obtener el porcentaje de descuento según el total de la compra
        private double ObtenerDescuento(double total)
        {
            if (total >= 0.01 && total <= 1000.00)
            {
                return 10.0;
            }
            else if (total > 1000.00 && total <= 3000.00)
            {
                return 20.0;
            }
            else if (total > 3000.00)
            {
                return 30.0;
            }
            else
            {
                return 0.0;
            }
        }
    }
}
