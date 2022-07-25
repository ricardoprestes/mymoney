using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyMoney.Views;

namespace MyMoney.ViewModels
{
    public partial class NewAccountViewModel : BaseViewModel
    {
        public NewAccountViewModel()
        {
            CreateNewAccountCommand = new AsyncRelayCommand(CreateNewAccount, SingUpCanExecute);
        }

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(CreateNewAccountCommand))]
        string name;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(CreateNewAccountCommand))]
        string email;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(CreateNewAccountCommand))]
        string password;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(CreateNewAccountCommand))]
        string confirmPassword;

        public IAsyncRelayCommand CreateNewAccountCommand { get; }

        public async Task CreateNewAccount()
        {
            if(PasswordMatch() is false)
            {
                await Shell.Current.DisplayAlert("Password not match", "Password and confirm password not match.", "Ok");
                return;
            }

            await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
        }

        private bool SingUpCanExecute()
        {
            return string.IsNullOrWhiteSpace(Name) is false &&
                   string.IsNullOrWhiteSpace(Email) is false &&
                   string.IsNullOrWhiteSpace(Password) is false &&
                   string.IsNullOrWhiteSpace(ConfirmPassword) is false;
        }

        private bool PasswordMatch() => Password == ConfirmPassword;
    }
}

