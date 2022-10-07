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
    public partial class Conocimientos : ContentPage {
        public List<producto> productos;
        public List<producto> analisises;
        public Conocimientos() {

            productos = new List<producto>();
            productos.Add(new producto { indicador = "•", descripcion = "Desarrollo full stack" });
            productos.Add(new producto { indicador = "•", descripcion = "Aplicaciones y sitios web" });
            productos.Add(new producto { indicador = "•", descripcion = "Aplicaciones móviles para iOS y Android" });
            productos.Add(new producto { indicador = "•", descripcion = "Servicios web y otros tipos de EDI" });
            productos.Add(new producto { indicador = "•", descripcion = "Integración de facturación electrónica a sistemas existentes" });
            productos.Add(new producto { indicador = "•", descripcion = "Desarrollo de sistemas de punto de venta" });
            productos.Add(new producto { indicador = "•", descripcion = "Soluciones de web scrapping" });

            analisises = new List<producto>();
            analisises.Add(new producto { indicador = "•", descripcion = "Levantamiento de requerimientos técnicos" });
            analisises.Add(new producto { indicador = "•", descripcion = "Analisis funcional del desarrollo" });
            analisises.Add(new producto { indicador = "•", descripcion = "Integracion de propuestas de desarrollo de software" });
            analisises.Add(new producto { indicador = "•", descripcion = "Seguimiento de proyectos con metodología SCRUM" });


            InitializeComponent();
            LabelTranslation(Preferences.Get("app-language", "0"));
            listaProductos.ItemsSource = productos;
            listaProductos2.ItemsSource = analisises;
        }

        protected void LabelTranslation(string language) {
            if (language == "en-us") {
                Title = "Knowledge and skills";
                lbl_software_dev.Text = "Software development";
                lbl_analysis.Text = "Analysis";

                //TODO: Traducción automatica
                productos[0].descripcion = "Full-Stack development";
                productos[1].descripcion = "Websites and Web Applications";
                productos[2].descripcion = "iOS and Android mobile apps";
                productos[3].descripcion = "WebServices and other information exchanges technologies";
                productos[4].descripcion = "Electronic invoicing solutions";
                productos[5].descripcion = "Point of Sale (POS) software development";
                productos[6].descripcion = "Web scrapping solutions";

                analisises[0].descripcion = "Technical requirements' identification in software developments";
                analisises[1].descripcion = "Functional Analysis";
                analisises[2].descripcion = "Software development pitch-proposal integration";
                analisises[3].descripcion = "SCRUM-based software development management and development";
            }
        }

        protected override void OnAppearing() {
            expandirSecciones();
        }

        private async void expandirSecciones() {
            panel1.IsExpanded = true;
            panel2.IsExpanded = true;
            //panel3.IsExpanded = true;
            panel1.ForceUpdateSize();
            panel2.ForceUpdateSize();
            //panel3.ForceUpdateSize();
        }


        public class producto {
            public string indicador { get; set; }
            public string descripcion { get; set; }
        }
    }
}