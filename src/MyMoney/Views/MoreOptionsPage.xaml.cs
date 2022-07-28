using MyMoney.ViewModels;

namespace MyMoney.Views;

public partial class MoreOptionsPage : ContentPage
{
	public MoreOptionsPage(MoreOptionsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
