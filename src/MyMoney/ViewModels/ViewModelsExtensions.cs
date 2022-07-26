using System;

namespace MyMoney.ViewModels
{
    public static class ViewModelsExtensions
    {
        public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<LoginViewModel>();
            builder.Services.AddSingleton<NewAccountViewModel>();
            builder.Services.AddSingleton<DashboardViewModel>();
            //builder.Services.AddSingleton<MovimentationViewModel>();
            //builder.Services.AddSingleton<BudgetPViewModel>();

            return builder;
        }
    }
}

