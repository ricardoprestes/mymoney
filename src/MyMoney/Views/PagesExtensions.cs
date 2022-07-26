using System;

namespace MyMoney.Views
{
    public static class PagesExtensions
    {
        public static MauiAppBuilder ConfigurePages(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<NewAccountPage>();
            builder.Services.AddSingleton<DashboardPage>();
            builder.Services.AddSingleton<MovimentationPage>();
            builder.Services.AddSingleton<BudgetPage>();

            return builder;
        }
    }
}

