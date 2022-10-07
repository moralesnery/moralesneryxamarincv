using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace moralesneryxamarincv.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Experiencia : ContentPage {
        public Experiencia() {
            List<Trabajo> trabajosanteriores = new List<Trabajo>();
            trabajosanteriores.Add(new Trabajo { Periodo = "2014 - 2015", Lugar="Tenaris-Tamsa", Direccion="Practicas Profesionales", NoUltimo = true });
            trabajosanteriores.Add(new Trabajo { Periodo = "2015 - 2016", Lugar="SuperSmart de Veracruz (Corporativo Yepas)", Direccion="Desarrollador Jr.", NoUltimo = true });
            trabajosanteriores.Add(new Trabajo { Periodo = "2016 - 2017", Lugar="TRADICOMM", Direccion="Ing. de Soporte (Mesa de Ayuda de Desarrollo)", NoUltimo = true });
            trabajosanteriores.Add(new Trabajo { Periodo = "2017 - Actual", Lugar="Administración del Sistema Portuario Nacional Veracruz", Direccion="Coordinador de Informática", NoUltimo = false });
            InitializeComponent();
            timelineListView.ItemsSource = trabajosanteriores;
        }

        private void timelineListView_ItemTapped(object sender, ItemTappedEventArgs e) {
            //Abrir el popup
        }

        public class Trabajo {
            public string Periodo { get; set; }
            public string Lugar { get; set; }
            public string Direccion { get; set; }
            public bool NoUltimo { get; set; }
        }

    }
}