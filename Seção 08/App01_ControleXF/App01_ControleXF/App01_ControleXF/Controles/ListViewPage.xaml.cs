using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App01_ControleXF.Modelo; 

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();
            List<Pessoa> lista = new List<Pessoa>
            {
                new Pessoa { Nome = "jose", Idade = "34" },
                new Pessoa { Nome = "marcos", Idade = "21" },
                new Pessoa { Nome = "maria", Idade = "33" },
                new Pessoa { Nome = "joana", Idade = "45" },
                new Pessoa { Nome = "tereza", Idade = "67" },
                new Pessoa { Nome = "rut", Idade = "12" }
            };

            ListaPessoas.ItemsSource = lista;

        }
	}
}