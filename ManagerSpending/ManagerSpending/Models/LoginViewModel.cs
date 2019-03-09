using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSpending.Models
{
    public class LoginViewModel: ViewModels.Base.ViewModelBase
    {
        private string _email;
        private string _password;

        public string Email {
            get => _email;
            set {
                if (SetProperty(ref _email, value))
                    LoginCommand.RaiseCanExecuteChanged();
            }
        }

        public string Password {
            get => _password;
            set
            {
                if (SetProperty(ref _password, value))
                    LoginCommand.RaiseCanExecuteChanged();
            }
        }
        
        public Mvvm.Commands.DelegateCommand LoginCommand { get; }

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        ///                                                Method                                           //
        //////////////////////////////////////////////////////////////////////////////////////////////////////

        public LoginViewModel()
        {
            LoginCommand = new Mvvm.Commands.DelegateCommand(Login, CanLogin);
        }

        public async void Login()
        {
            IsBusy = true;
            await Task.Delay(2000);
            IsBusy = false;
        }

        public bool CanLogin()
        {
            return CanLoginAction();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        ///                                                Handle                                           //
        //////////////////////////////////////////////////////////////////////////////////////////////////////

        private bool CanLoginAction()
        {
            return !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password);
        }
    }
}
