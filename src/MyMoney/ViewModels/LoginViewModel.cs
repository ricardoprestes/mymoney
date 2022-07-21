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
        }

        public IAsyncRelayCommand LoginCommand { get; }

        public async Task Login()
        {
            await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
        }
    }
}

