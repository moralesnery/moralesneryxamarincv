using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using moralesneryxamarincv.Views;

namespace moralesneryxamarincv {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage {
        public Home() {
            InitializeComponent();
            container.FadeTo(1, 3000);
        }

        private async void btnCV_Tapped(object sender, EventArgs e) {
            Frame boton = (Frame)sender;


            await boton.ScaleTo(0.8, 50);
            await boton.ScaleTo(1.0, 50);
            //await Navigation.PushAsync();

            if (boton.Equals(btnCV)){
                await Navigation.PushAsync(new CV());
            }
            if (boton.Equals(btnExperiencia)) {
                await Navigation.PushAsync(new Experiencia());
            }
            if (boton.Equals(btnTecnologías)) {
                await Navigation.PushAsync(new Conocimientos());            
            }
            if (boton.Equals(btnContacto)) {
                await Navigation.PushAsync(new Contacto());
            }
        }
    }
}