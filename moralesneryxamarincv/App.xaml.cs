using moralesneryxamarincv.Services;
using moralesneryxamarincv.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Lato-Black.ttf", Alias = "LatoBlack")]
[assembly: ExportFont("Lato-BlackItalic.ttf", Alias = "LatoBlackItalic")]
[assembly: ExportFont("Lato-Bold.ttf", Alias = "LatoBold")]
[assembly: ExportFont("Lato-BoldItalic.ttf", Alias = "LatoBoldItalic")]
[assembly: ExportFont("Lato-Italic.ttf", Alias = "LatoItalic")]
[assembly: ExportFont("Lato-Light.ttf", Alias = "LatoLight")]
[assembly: ExportFont("Lato-LightItalic.ttf", Alias = "LatoLightItalic")]
[assembly: ExportFont("Lato-Regular.ttf", Alias = "Lato")]
[assembly: ExportFont("Lato-Thin.ttf", Alias = "LatoThin")]
[assembly: ExportFont("Lato-ThinItalic.ttf", Alias = "LatoThinItalic")]

namespace moralesneryxamarincv {
    public partial class App : Application {

        public App() {
            InitializeComponent();


            DependencyService.Register<MockDataStore>(); //?

            MainPage = new NavigationPage(new Home());
        }

        protected override void OnStart() {
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
        }
    }
}
