using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ManagerSpending.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
		public LoginView ()
		{
			InitializeComponent ();

            BindingContext = new Models.LoginViewModel();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(2000);

            await Task.WhenAll(
                SplashGrid.FadeTo(0, 2000),
                logo.ScaleTo(10, 2000)
            );

            SplashGrid.IsVisible = false;
        }
    }
}