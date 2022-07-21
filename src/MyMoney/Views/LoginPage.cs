using CommunityToolkit.Maui.Markup;
using MyMoney.ViewModels;

namespace MyMoney.Views;

public class LoginPage : ContentPage
{
	public LoginPage()
	{
		Shell.SetFlyoutBehavior(this, FlyoutBehavior.Disabled);
		Shell.SetNavBarIsVisible(this, false);

		var viewModel = new LoginViewModel();
		Content = new StackLayout
		{
			Children = {
				new Label { Text = "Welcome to .NET MAUI!" },
				new Button { Text = "Entrar" }.Bind(Button.CommandProperty, nameof(viewModel.LoginCommand))
			}
		};

		BindingContext = viewModel;
	}
}
