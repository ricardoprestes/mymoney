using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using MyMoney.ViewModels;
using MyMoney.Views;

namespace MyMoney;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("fa_solid.ttf", "FontAwesome");
			})
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitMarkup();

		builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<NewAccountPage>();
        builder.Services.AddSingleton<DashboardPage>();
        builder.Services.AddSingleton<MovimentationPage>();
        builder.Services.AddSingleton<BudgetPage>();

        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<NewAccountViewModel>();
        builder.Services.AddSingleton<DashboardViewModel>();
        //builder.Services.AddSingleton<MovimentationViewModel>();
        //builder.Services.AddSingleton<BudgetPViewModel>();

        return builder.Build();
	}
}
