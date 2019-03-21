using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ManagerSpending.Models
{
    public class MasterPageItem
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }
    }

    public class MasterDetailPage : ViewModels.Base.ViewModelBase
    {
        public ObservableCollection<MasterPageItem> masterItems { get; set; }

        public MasterDetailPage()
        {
            masterItems = new ObservableCollection<MasterPageItem>(new List<MasterPageItem>());
            // Adding menu items to menuList and you can define title ,page and icon
            masterItems.Add(new MasterPageItem() { Title = "Home", Icon = "fblogo.png"});
            masterItems.Add(new MasterPageItem() { Title = "Setting", Icon = "glogo.png"});
            masterItems.Add(new MasterPageItem() { Title = "Help", Icon = "icon.png"});
            masterItems.Add(new MasterPageItem() { Title = "LogOut", Icon = "fblogo.png"});
        }
    }


}
