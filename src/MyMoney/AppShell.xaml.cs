using MyMoney.Views;
using MyMoney.Helpers;
using BurgerMonkeys.Tools;

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
        //var token = Settings.GetToken();
        //if(token.IsNotNullOrWhiteSpace())
        //    await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
    }
}
