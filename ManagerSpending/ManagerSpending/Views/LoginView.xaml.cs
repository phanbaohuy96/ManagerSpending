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
            ((Models.LoginViewModel)BindingContext).LoginSuccessfully += LoginView_LoginSuccessfully;
		}

        private void LoginView_LoginSuccessfully(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Task.WhenAll(
                SplashGrid.FadeTo(0, 2000),
                logo.ScaleTo(10, 2000)
            );

            SplashGrid.IsVisible = false;
        }

        private void EmailEntry_Completed(object sender, EventArgs e) => passwordEntry.Focus();        

        private void PasswordEntry_Completed(object sender, EventArgs e)
        {
            if (btnLogin.Command.CanExecute(null)) btnLogin.Command.Execute(null);
        }
    }
}