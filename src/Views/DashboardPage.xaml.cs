using MyMoney.ViewModels;

namespace MyMoney.Views;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
		BindingContext = new DashboardViewModel();
	}
}

