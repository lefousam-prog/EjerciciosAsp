using System;
using System.Web.UI;

namespace Ejercicio5
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
                // Obtener las notas ingresadas
                double e1 = Convert.ToDouble(txtE1.Text);
                double e2 = Convert.ToDouble(txtE2.Text);
                double e3 = Convert.ToDouble(txtE3.Text);
                double e4 = Convert.ToDouble(txtE4.Text);
                double e5 = Convert.ToDouble(txtE5.Text);

                // Calcular el promedio
                double promedio = (e1 + e2 + e3 + e4 + e5) / 5;

                // Mostrar el promedio en el Label del modal
                lblPromedio.Text = $"El promedio de {txtNombre.Text} es: {promedio}";

                // Mostrar el modal
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "mostrarModal();", true);
            }
            catch (Exception ex)
            {
                // Manejar excepciones si no se ingresan números válidos
                lblPromedio.Text = "Por favor ingresa números válidos en las notas.";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "mostrarModal();", true);
            }
        }
    }
}
