using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ManagerSpending.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new Models.MasterDetailPage();

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }        
    }
}
