using System;
using BurgerMonkeys.Tools;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyMoney.Services;
using MyMoney.Views;
using MyMoney.Helpers;

namespace MyMoney.ViewModels
{
    public partial class NewAccountViewModel : BaseViewModel
    {
        private readonly IFirebaseAuthService _firebaseAuthService;

        public NewAccountViewModel(IFirebaseAuthService firebaseAuthService)
        {
            _firebaseAuthService = firebaseAuthService;

            CreateNewAccountCommand = new AsyncRelayCommand(CreateNewAccount, SignUpCanExecute);
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
            if(Email.IsEmail() is false)
            {
                await Shell.Current.DisplayAlert("Invalid email", "Provide a valid email.", "Ok");
                return;
            }

            if(PasswordMatch() is false)
            {
                await Shell.Current.DisplayAlert("Password not match", "Password and confirm password not match.", "Ok");
                return;
            }

            IsBusy = true;

            try
            {
                var token = await _firebaseAuthService.SingUp(Name, Email, Password);
                Settings.SaveToken(token);
                await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("EMAIL_EXISTS"))
                    await Shell.Current.DisplayAlert("Invalid email", "This email is already in use.", "Ok");
                else
                    await Shell.Current.DisplayAlert("Sign up problem", "An error has occurred, please check your details and try again.", "Ok");
            }

            IsBusy = false;

        }

        private bool SignUpCanExecute()
        {
            return string.IsNullOrWhiteSpace(Name) is false &&
                   string.IsNullOrWhiteSpace(Email) is false &&
                   string.IsNullOrWhiteSpace(Password) is false &&
                   string.IsNullOrWhiteSpace(ConfirmPassword) is false;
        }

        private bool PasswordMatch() => Password == ConfirmPassword;
    }
}

