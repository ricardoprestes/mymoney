using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using MyMoney.Helpers;
using MyMoney.Services;
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
			.ConfigureServices()
			.ConfigurePages()
			.ConfigureViewModels()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("fa_solid.ttf", "FontAwesome");
			})
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitMarkup();

        return builder.Build();
	}
}
