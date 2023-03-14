using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwitchClase.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeraPaginaView : ContentPage
    {
        public PrimeraPaginaView()
        {
            InitializeComponent();
            txtNombre.Text = Preferences.Get("Nombre Guardado","");
            RememberSwitch.IsToggled = Preferences.Get("Guarado Correctamente", false);
            
        }

        public async void Button_Clicked(object sender, EventArgs e) { 
            
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            string direccion = txtDir.Text;
            string celular = txtCel.Text;
            await Application.Current.MainPage.Navigation.PushModalAsync(new SegundaPaginaView(nombre, apellido,
                dni, direccion, celular));
        
        }

        private void RememberMe_toggle_Switch(object sender, ToggledEventArgs e)
        {
            if (RememberSwitch.IsToggled == true)
            {
                Preferences.Set("Nombre Guardado", txtNombre.Text);
                Preferences.Set("Guardado Correctamente", RememberSwitch.IsToggled == true);
                RememberSwitch.ThumbColor = Color.Red;
                RememberSwitch.OnColor = Color.Green;
            }
            else
            {
                Preferences.Remove("Elimando Correctamente");
                Preferences.Remove("Borrado");
                RememberSwitch.ThumbColor= Color.Gray;
            }
        }
            

    }
}