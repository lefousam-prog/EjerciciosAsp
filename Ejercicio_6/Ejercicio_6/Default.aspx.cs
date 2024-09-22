using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio_6
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Generar botones dinámicamente del 1 al 9 como ImageButton
                for (int i = 1; i <= 9; i++)
                {
                    ImageButton imgNumber = new ImageButton
                    {
                        ImageUrl = $"~/Imagenes/{i}.png", // Ruta de la imagen
                        CssClass = "number-image",
                        PostBackUrl = $"~/Default.aspx?number={i}" // Agregar URL para manejar el clic
                    };

                    // Agregar atributo para manejar el evento de clic
                    imgNumber.Attributes.Add("onclick", $"showMultiplicationTable({i}); return false;");

                    numberTable.Controls.Add(imgNumber);
                }
            }
        }
    }
}
