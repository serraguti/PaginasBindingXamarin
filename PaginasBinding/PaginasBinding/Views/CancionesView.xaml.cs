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
    public partial class CancionesView : ContentPage
    {
        public CancionesView()
        {
            InitializeComponent();
            List<Cancion> canciones = new List<Cancion>
            {
                new Cancion()
                {
                     Titulo = "Cuando zarpa el amor",
                     Artista = "Camela",
                     Imagen = "https://s03.s3c.es/imag/efe/2013/08/13/20130813-5517529w.jpg"
                },
                new Cancion()
                {
                     Titulo = "El baile del Gorila",
                     Artista = "Melody",
                     Imagen = "https://i.ytimg.com/vi/iaT-o-3aulg/maxresdefault.jpg"
                },
                new Cancion()
                {
                     Titulo = "Bailamos",
                     Artista = "Enrique Iglesias",
                     Imagen = "http://www.tuconcierto.net/wp-content/uploads/2020/04/Enrique_Iglesias-Chapman_Baehler11.jpg"
                },
                new Cancion()
                {
                     Titulo = "Dame Veneno",
                     Artista = "Los Chunguitos",
                     Imagen = "https://images-na.ssl-images-amazon.com/images/I/61ODEbTXTBL._SX355_.jpg"
                }
            };
            this.listviewCanciones.ItemsSource = canciones;
        }
    }
}