﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerPage : ContentPage
	{
		public PickerPage ()
		{
			InitializeComponent ();
		}

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker obj = (Picker)sender;
            Resultado.Text = obj.SelectedIndex.ToString()+"-" + obj.SelectedItem.ToString();
        }
    }
}