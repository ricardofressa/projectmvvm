using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProjectMVVM
{
	public partial class HomeViewPage : ContentPage
	{
		public HomeViewPage()
		{
			InitializeComponent();
			BindingContext = new HomeViewModel();
		}
	}
}
