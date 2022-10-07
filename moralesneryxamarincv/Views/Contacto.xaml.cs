using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace moralesneryxamarincv.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contacto : ContentPage {
        public Contacto() {
            InitializeComponent();
            LabelTranslation(Preferences.Get("app-language", "0"));
        }

        protected void LabelTranslation(string language) {
            if (language == "en-us") {
                Title = "Contact";
                lbl_mail.Text = "E-mail:";
                lbl_phone.Text = "Phone:";
                lbl_links.Text = "Links:";
                
            }
        }

        private async void btnMailto_Clicked(object sender, EventArgs e) {
            Label control = (Label)sender;

            await control.ScaleTo(0.8, 50);
            await control.ScaleTo(1.0, 50);

            EmailMessage msgcontacto = new EmailMessage();
            msgcontacto.Subject = "Contacto";
            msgcontacto.BodyFormat = EmailBodyFormat.Html;
            msgcontacto.Body = "<h3>Escribe tu mensaje aquí</h3>";
            msgcontacto.To.Add("moralesnery@yahoo.com.mx");
            Email.ComposeAsync(msgcontacto);
        }

        private async void btnEnlace_Tapped(object sender, EventArgs e) {
            StackLayout control = (StackLayout)sender;

            await control.ScaleTo(0.8, 50);
            await control.ScaleTo(1.0, 50);

            if (control.Equals(btnGitHub)) {
                await Browser.OpenAsync("https://github.com/moralesnery", BrowserLaunchMode.SystemPreferred);
            }

            if (control.Equals(btnLinkedIn)) {
                await Browser.OpenAsync("https://mx.linkedin.com/in/moralesnery", BrowserLaunchMode.SystemPreferred);
            }
        }

        private async void btnLlamar_Tapped(object sender, EventArgs e) {
            Label control = (Label)sender;

            await control.ScaleTo(0.8, 50);
            await control.ScaleTo(1.0, 50);

            PhoneDialer.Open("+522291537619");
        }
    }
}