using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            txtNombre.Text = Preferences.Get("Nombre Guardado", "");
            RememberSwitch.IsToggled = Preferences.Get("Guarado Correctamente", false);

        
        }



        public bool VerificarEdad(int anioNacimiento)
        {
            int edad = DateTime.Today.Year - anioNacimiento;

            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private async void BtnVerificarEdad_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string mensaje = txtAnioNacimiento.Text;
            


            int anioNacimiento = Convert.ToInt32(txtAnioNacimiento.Text);
            bool esMayorDeEdad = VerificarEdad(anioNacimiento);

            if (esMayorDeEdad)
            {
                await Application.Current.MainPage.Navigation.PushModalAsync(new SegundaPaginaView(nombre," es mayor de edad."));
            }
            else
            {
                await Application.Current.MainPage.Navigation.PushModalAsync(new SegundaPaginaView(nombre, "es menor de edad."));
            }
        }
        private void RememberMe_toggle_Switch(object sender, ToggledEventArgs e)
        {
            if (RememberSwitch.IsToggled == true)
            {
                Preferences.Set("Nombre Guardado", txtNombre.Text);
                Preferences.Set("Guardado Correctamente", RememberSwitch.IsToggled == true);
                RememberSwitch.ThumbColor = Color.Red;
                RememberSwitch.OnColor = Color.Firebrick;
            }
            else
            {
                Preferences.Remove("Elimando Correctamente");
                Preferences.Remove("Borrado");
                RememberSwitch.ThumbColor = Color.Gray;
            }
        }




    }
}