using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.CommunityToolkit;
using System.ComponentModel;
using Xamarin.CommunityToolkit.UI.Views;
using System.Xml.Linq;
using System.Threading;
using Xamarin.Essentials;

namespace moralesneryxamarincv.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CV : ContentPage {
        public CV() {
            InitializeComponent();
            LabelTranslation(Preferences.Get("app-language", "0"));
        }

        protected void LabelTranslation(string language) {
            if (language == "en-us") {
                Title = "Academic training and Studies";
                lbl_hs.Text = "High School";
                lbl_hs_name.Text = "Professional Technical Education's National College";
                lbl_hs_grade.Text = "IT Technician";
                lbl_univ.Text = "University";
                lbl_univ_name.Text = "Veracruz Institute of Technology";
                lbl_univ_grade.Text = "Computer Systems Engineer";
                lbl_c.Text = "Other courses and certifications";
                lbl_c1.Text = "Electronic Invoicing CFDI 4.0";
                lbl_c2.Text = "MTA 98-349: Windows OS Cert";
                lbl_c3.Text = "Introduction to Public Administration (LFRSP)";
                lbl_c4.Text = "Multi-platform mobile development";
            } 
        }

        protected override void OnAppearing() {
            expandirSecciones();
        }

        private async void expandirSecciones() {
            panel1.IsExpanded = true;
            panel2.IsExpanded = true;
            panel3.IsExpanded = true;
            panel1.ForceUpdateSize();
            panel2.ForceUpdateSize();
            panel3.ForceUpdateSize();
        }
    }
}