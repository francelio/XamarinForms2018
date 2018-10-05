﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_Xamarin.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
    {
		public Menu ()
		{
			InitializeComponent ();
		}

        private void GoPaginaPerfil1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Perfil1());
            IsPresented = false;
           
        }
        private void GoPaginaPerfil2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Perfil2());
            IsPresented = false;
           
        }
        private void GoPaginaPerfil3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Perfil3());
            IsPresented = false;
        }
        private void GoPaginaXamarin(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Xamarin());
            IsPresented = false;
        }
    }
}