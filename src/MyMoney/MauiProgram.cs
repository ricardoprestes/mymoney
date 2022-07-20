﻿using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;

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

		return builder.Build();
	}
}
