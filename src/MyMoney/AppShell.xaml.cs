using MyMoney.Views;

namespace MyMoney;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(NewAccountPage), typeof(NewAccountPage));
	}
}
