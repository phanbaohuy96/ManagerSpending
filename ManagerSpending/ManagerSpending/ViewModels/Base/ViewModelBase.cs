using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerSpending.ViewModels.Base
{
    public class ViewModelBase : Mvvm.BindableBase
    {
        private bool _isBusy;
        private bool _isNotBusy => !IsBusy;

        private string _title;

        public string Title {
            get => _title;
            set => SetProperty(ref _title , value);
        }

        public bool IsBusy {
            get => _isBusy;
            set {
                if (SetProperty(ref _isBusy, value))
                    RaisePropertyChanged(nameof(_isNotBusy));
            }
        }


        public ViewModelBase()
        {
        }
    }
}
