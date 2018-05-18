﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Minutess
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntriesPage : ContentPage
	{
		public EntriesPage ()
		{
			InitializeComponent ();
		}
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            entries.ItemsSource = await App.Entries.ReadAsync();
        }
    }
}