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

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (Models.MasterPageItem)e.SelectedItem;

            Type page = item.TargetType;
            if(page != null && ((Models.MasterDetailPage)BindingContext).CurrentPage != page)
                Detail = new NavigationPage((Page)Activator.CreateInstance(page));

            //close naivgation menu
            IsPresented = false;
        }
    }
}
