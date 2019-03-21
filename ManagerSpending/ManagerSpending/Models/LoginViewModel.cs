using System;
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

        public bool IsEnableLogin
        {
            get => !IsBusy;
            set
            {
                IsBusy = value;
                LoginCommand.RaiseCanExecuteChanged();
            }
        }

        public Mvvm.Commands.DelegateCommand LoginCommand { get; }

        public event EventHandler LoginSuccessfully;

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        ///                                                Method                                           //
        //////////////////////////////////////////////////////////////////////////////////////////////////////

        public LoginViewModel()
        {
            LoginCommand = new Mvvm.Commands.DelegateCommand(Login, CanLogin);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        ///                                                Handle                                           //
        //////////////////////////////////////////////////////////////////////////////////////////////////////

        public async void Login()
        {
            IsEnableLogin = true;
            await Task.Delay(2000);
            IsEnableLogin = false;
            LoginSuccessfully?.Invoke(null, null);
        }

        public bool CanLogin()
        {
            return !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password) && IsEnableLogin;
        }
    }
}
