using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using moralesneryxamarincv.Views;
using Xamarin.Essentials;

namespace moralesneryxamarincv {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage {
        public Home() {
            InitializeComponent();
            LabelTranslation(Preferences.Get("app-language","0"));
        }

        protected void LabelTranslation(string language) {
            
            if (language == "en-us") {
                switchIdioma.IsToggled = true;
                //lbl_name.Text = "";
                lbl_studied.Text = "ISC - Software Developer";
                lbl_cv.Text = "Studies and training";
                lbl_knowledge.Text = "Knowledge";
                lbl_experience.Text = "Workplace experience";
                lbl_contact.Text = "Contact";
            } else {
                switchIdioma.IsToggled = false;
            }
        }

        protected override async void OnAppearing() {
            base.OnAppearing();
            await foto.FadeTo(1, 300);
            await lbl_name.FadeTo(1, 300);
            await lbl_studied.FadeTo(1, 200);
            await btnCV.FadeTo(1, 100);
            await btnTecnologías.FadeTo(1, 100);
            await btnExperiencia.FadeTo(1, 100);
            await btnContacto.FadeTo(1, 100);

            //await btnContacto.ScaleTo(1.3, 150);
            //await btnContacto.ScaleTo(1.0, 50);
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

        private void switchIdioma_Toggled(object sender, ToggledEventArgs e) {
            Switch control = (Switch)sender;

            string actual_language = Preferences.Get("app-language", "0");

            if (control.IsToggled && actual_language == "en-us") {
                //No es necesario ningun cambio

            } else if (control.IsToggled && actual_language == "es-mx") {
                //Traducir a inglés
                Preferences.Set("app-language", "en-us");
                (Application.Current).MainPage = new NavigationPage(new Home());

            } else if (!(control.IsToggled) && actual_language == "en-us") {
                //Traducir a español
                Preferences.Set("app-language", "es-mx");
                (Application.Current).MainPage = new NavigationPage(new Home());

            } else {
                //Dejar en español
                Preferences.Set("app-language", "es-mx");
                (Application.Current).MainPage = new NavigationPage(new Home());
            }

            
        }
    }
}