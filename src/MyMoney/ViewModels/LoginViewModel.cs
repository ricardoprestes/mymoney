using System;
using BurgerMonkeys.Tools;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyMoney.Services;
using MyMoney.Views;

namespace MyMoney.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        private readonly IFirebaseAuthService _firebaseAuthService;

        public LoginViewModel(IFirebaseAuthService firebaseAuthService)
        {
            _firebaseAuthService = firebaseAuthService;

            SignInCommand = new AsyncRelayCommand(SignIn, SignInCanExecute);
            NewAccountCommand = new AsyncRelayCommand(NavigateToNewAccountPage);
        }


        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(SignInCommand))]
        string email;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(SignInCommand))]
        string password;

        public IAsyncRelayCommand SignInCommand { get; }
        public IAsyncRelayCommand NewAccountCommand { get; }


        public async Task SignIn()
        {
            if (Email.IsEmail() is false)
            {
                await Shell.Current.DisplayAlert("Invalid email", "Provide a valid email.", "Ok");
                return;
            }

            await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
        }

        public async Task NavigateToNewAccountPage()
        {
            await Shell.Current.GoToAsync($"{nameof(NewAccountPage)}");
        }

        private bool SignInCanExecute()
        {
            return string.IsNullOrWhiteSpace(Email) is false &&
                   string.IsNullOrWhiteSpace(Password) is false;
        }
    }
}

