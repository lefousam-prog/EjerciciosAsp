using System;
using System.Web.UI;

namespace eercicio2
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el salario base ingresado
                double salarioBase = Convert.ToDouble(txtSalarioBase.Text);

                // Calcular descuentos
                double descuentoISSS = CalcularISSS(salarioBase);
                double descuentoRenta = CalcularRenta(salarioBase);
                double descuentoAFP = CalcularAFP(salarioBase);
                double descuentoSeguro = CalcularSeguro(salarioBase);

                // Calcular el total de descuentos
                double totalDescuentos = descuentoISSS + descuentoRenta + descuentoAFP + descuentoSeguro;

                // Calcular el salario neto después de aplicar los descuentos
                double salarioNeto = salarioBase - totalDescuentos;

                // Mostrar los resultados en la página
                lblResultado.Text = $"Salario Base: {salarioBase:C}<br/>" +
                                    $"Descuento ISSS: {descuentoISSS:C} (3% para salarios > 657.25)<br/>" +
                                    $"Descuento Renta: {descuentoRenta:C} (10% para salarios > 857.15)<br/>" +
                                    $"Descuento AFP: {descuentoAFP:C} (5% para salarios > 450)<br/>" +
                                    $"Descuento Seguro: {descuentoSeguro:C} ({(salarioBase < 1000 ? "4%" : "6%")})<br/>" +
                                    $"Total de Descuentos: {totalDescuentos:C}<br/>" +
                                    $"Salario Neto: {salarioNeto:C}";
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si los datos ingresados no son válidos
                lblResultado.Text = "Por favor, ingresa un valor numérico válido para el salario base.";
            }
        }

        // Método para calcular el descuento de ISSS
        private double CalcularISSS(double salario)
        {
            return salario > 657.25 ? salario * 0.03 : 0;
        }

        // Método para calcular el descuento de Renta
        private double CalcularRenta(double salario)
        {
            return salario > 857.15 ? salario * 0.10 : 0;
        }

        // Método para calcular el descuento de AFP
        private double CalcularAFP(double salario)
        {
            return salario > 450 ? salario * 0.05 : 0;
        }

        // Método para calcular el descuento de Seguro
        private double CalcularSeguro(double salario)
        {
            return salario < 1000 ? salario * 0.04 : salario * 0.06;
        }
    }
}
