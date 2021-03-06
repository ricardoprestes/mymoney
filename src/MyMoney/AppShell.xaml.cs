using MyMoney.Views;
using MyMoney.Helpers;
using BurgerMonkeys.Tools;
using Newtonsoft.Json;
using Firebase.Auth;
using MyMoney.Services;

namespace MyMoney;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(NewAccountPage), typeof(NewAccountPage));
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await OnAppearingAsync();
    }

	private async Task OnAppearingAsync()
    {
        var token = Settings.GetToken();
        if (token.IsNotNullOrWhiteSpace())
        {
            var auth = JsonConvert.DeserializeObject<FirebaseAuth>(token);
            var service = new FirebaseAuthService();
            auth = await service.RefreshAuth(auth);

            if (auth.IsExpired() is false)
                await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");


        }
    }
}
