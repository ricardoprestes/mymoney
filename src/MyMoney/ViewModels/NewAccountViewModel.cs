using System;
using CommunityToolkit.Mvvm.Input;
using MyMoney.Views;

namespace MyMoney.ViewModels
{
    public class NewAccountViewModel : BaseViewModel
    {
        public NewAccountViewModel()
        {
            CreateNewAccountCommand = new AsyncRelayCommand(CreateNewAccount);
        }

        public IAsyncRelayCommand CreateNewAccountCommand { get; }

        public async Task CreateNewAccount()
        {
            await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
        }
    }
}

