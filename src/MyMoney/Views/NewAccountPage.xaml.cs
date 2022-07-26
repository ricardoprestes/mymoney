using MyMoney.ViewModels;

namespace MyMoney.Views;

public partial class NewAccountPage : ContentPage
{
	public NewAccountPage(NewAccountViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
