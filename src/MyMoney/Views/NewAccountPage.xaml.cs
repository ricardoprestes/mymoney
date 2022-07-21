using MyMoney.ViewModels;

namespace MyMoney.Views;

public partial class NewAccountPage : ContentPage
{
	public NewAccountPage()
	{
		InitializeComponent();
		BindingContext = new NewAccountViewModel();
	}
}
