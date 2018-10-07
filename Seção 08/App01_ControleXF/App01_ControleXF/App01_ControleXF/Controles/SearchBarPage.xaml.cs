using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchBarPage : ContentPage
	{
        private List<string> empresasTi;
        public SearchBarPage ()
		{
			InitializeComponent ();
           empresasTi = new List<string>
            {
                "Microsoft",
                "Apple",
                "Oracle",
                "IBM",
                "SAP",
                "99Taxi",
                "UBER"
            };


            Preencher(empresasTi);
            

        }

        private void Preencher(List<string> empresasTI)
        {
            ListResult.Children.Clear();
            foreach (var emp in empresasTI)
            {
                ListResult.Children.Add(new Label {Text=emp});
            }
        }

        private void Pesquisar(object sender, TextChangedEventArgs e)
        {
          var resultado = empresasTi.Where(a => a.Contains(e.NewTextValue)).ToList<string>();
            Preencher(resultado);
        }
        private void PesquisarButton(object sender, EventArgs e)
        {
            var resultado = empresasTi.Where(a => a.Contains(((SearchBar)sender).Text)).ToList<string>();
            Preencher(resultado);
        }
    }
}