using System;
using System.Web.UI;

namespace Ejercicio1
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

                // Calcular descuento según el monto del salario base
                double descuento = CalcularDescuento(salarioBase);

                // Calcular el monto del descuento
                double montoDescuento = salarioBase * descuento;

                // Calcular el salario neto después de aplicar el descuento
                double salarioNeto = salarioBase - montoDescuento;

                // Mostrar los resultados en la página
                lblResultado.Text = $"Salario Base: {salarioBase:C}<br/>" +
                                    $"Descuento Aplicado: {descuento * 100}%<br/>" +
                                    $"Monto de Descuento: {montoDescuento:C}<br/>" +
                                    $"Salario Neto: {salarioNeto:C}";
            }
            catch (Exception)
            {
                // Mostrar mensaje de error si los datos ingresados no son válidos
                lblResultado.Text = "Por favor, ingresa un valor numérico válido para el salario base.";
            }
        }

        // Método para calcular el descuento basado en el salario
        private double CalcularDescuento(double salario)
        {
            if (salario >= 1 && salario <= 100)
            {
                return 0.10; // 10%
            }
            else if (salario > 100 && salario <= 400)
            {
                return 0.15; // 15%
            }
            else if (salario > 400 && salario <= 600)
            {
                return 0.20; // 20%
            }
            else if (salario > 600)
            {
                return 0.25; // 25%
            }
            else
            {
                return 0; // Sin descuento si el salario no cumple ninguna condición
            }
        }
    }
}
