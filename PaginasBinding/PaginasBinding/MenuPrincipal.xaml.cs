using PaginasBinding.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginasBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : MasterDetailPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            //NECESITAMOS UNA COLECCION CON TODAS LAS PAGINAS
            List<MasterPageItem> paginas = new List<MasterPageItem>();
            var page1 =
                new MasterPageItem() { Titulo = "Pagina Hija 1"
                , PaginaHija = typeof(PaginaHija1)};
            var page2 =
                new MasterPageItem() { Titulo = "Pagina Hija 2"
                ,
                    PaginaHija = typeof(PaginaHija2)
                };
            var page3 =
                new MasterPageItem()
                {
                    Titulo = "Tabla Multiplicar"
                ,
                    PaginaHija = typeof(TablaMultiplicarView)
                };
            var page4 =
                new MasterPageItem()
                {
                    Titulo = "Tabbed View"
                ,
                    PaginaHija = typeof(TabbedView)
                };
            paginas.Add(page1);
            paginas.Add(page2);
            paginas.Add(page3);
            paginas.Add(page4);
            //INDICAMOS AL LISTVIEW SU ORIGEN DE DATOS
            this.lisviewMenu.ItemsSource = paginas;
            //INDICAMOS EN LA MASTER PAGE LA PAGINA QUE MOSTRARA
            //AL ARRANCAR COMO DETAIL
            this.Detail =
                new NavigationPage
                ((Page)Activator.CreateInstance(typeof(PaginaHija1)));
            //CUANDO SELECCIONEMOS SOBRE EL LISTVIEW
            //DEBEMOS REALIZAR LA NAVEGACION
            this.lisviewMenu.ItemSelected += LisviewMenu_ItemSelected;
        }

        private void LisviewMenu_ItemSelected(object sender
            , SelectedItemChangedEventArgs e)
        {
            //CUANDO SELECCIONAMOS UN ELEMENTO, NOS VIENE
            //EL VALOR DEL BINDING
            var page = (MasterPageItem)e.SelectedItem;
            Type type = page.PaginaHija;
            this.Detail = new NavigationPage((Page)
                Activator.CreateInstance(type));
            //COMO EFECTO OPTICO, CUANDO EL USUARIO
            //SELECCIONA UNA PAGINA, QUITAMOS EL MENU
            this.IsPresented = false;
        }
    }
}