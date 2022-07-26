using System;
using CommunityToolkit.Mvvm.Input;
using MyMoney.Views;

namespace MyMoney.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        public LoginViewModel()
        {
            LoginCommand = new AsyncRelayCommand(Login);
            NewAccountCommand = new AsyncRelayCommand(NavigateToNewAccountPage);
        }

        public IAsyncRelayCommand LoginCommand { get; }
        public IAsyncRelayCommand NewAccountCommand { get; }

        public async Task Login()
        {
            await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
        }

        public async Task NavigateToNewAccountPage()
        {
            await Shell.Current.GoToAsync($"{nameof(NewAccountPage)}");
        }
    }
}

