using PaginasBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginasBinding.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingClassView : ContentPage
    {
        public BindingClassView()
        {
            InitializeComponent();
            Coche car = new Coche();
            car.Marca = "Volkswagen";
            car.Modelo = "Golf GTI";
            car.Velocidad = 280;
            car.Imagen = "https://live.staticflickr.com/848/42935940604_5aaea4bd4d_b.jpg";
            //ENLAZAMOS LA INSTANCIA DEL COCHE CON LA PAGINA
            this.BindingContext = car;
        }
    }
}