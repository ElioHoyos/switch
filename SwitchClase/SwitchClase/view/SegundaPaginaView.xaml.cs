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
        public SegundaPaginaView(string nombre, string apellido, string dni, string direccion, string celular)
        {
            InitializeComponent();
            LabelNombre.Text = "Hola Señor " + nombre + " " + apellido;
            LabelDNI.Text = "Mi DNI es : " + dni;
            LabelDireccion.Text = "Mi Dirección es : " + direccion;
            LabelCelular.Text = "Mi número de celular es : " + celular;

        }
    }
}