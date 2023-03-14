using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwitchClase.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegundaPaginaView : ContentPage
    {
        public SegundaPaginaView(string nombre, string mensaje)
        {
            InitializeComponent();
            LabelNombre.Text = "Hola Señor " + nombre;
            lblMensaje.Text = mensaje;

        }
    }
}