using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Carousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3()
		{
			InitializeComponent ();
		}

        private void MudarPagina(object sender, EventArgs e)
        {   //sem navegation
            //App.Current.MainPage = new Navigation.Pagina1();
            //com navegation para pagina 1 
            //App.Current.MainPage = new NavigationPage(new Navigation.Pagina1()) { BarBackgroundColor=Color.Bisque};
            //com navegation para ABAS 
            App.Current.MainPage = new Tabbed.Abas();
        }
    }
}