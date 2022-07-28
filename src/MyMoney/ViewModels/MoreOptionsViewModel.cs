using CommunityToolkit.Mvvm.Input;
using MyMoney.Views;
using MyMoney.Helpers;

namespace MyMoney.ViewModels
{
    public class MoreOptionsViewModel : BaseViewModel
    {

        public MoreOptionsViewModel()
        {
            SignOutCommand = new AsyncRelayCommand(SignOut);
        }

        public IAsyncRelayCommand SignOutCommand { get; }

        public async Task SignOut()
        {
            var confirmSignOut = await Shell.Current.DisplayAlert("Sign Out", "Sign out of your account?", "Sign out", "Cancel");
            if (confirmSignOut is false)
                return;

            Settings.ClearToken();
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}

