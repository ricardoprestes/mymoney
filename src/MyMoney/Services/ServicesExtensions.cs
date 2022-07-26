using System;
using MyMoney.Services;

namespace MyMoney.Services
{
    public static class ServicesExtensions
    {
        public static MauiAppBuilder ConfigureServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IFirebaseAuthService, FirebaseAuthService>();
            return builder;
        }
    }
}
