using System;

namespace MyMoney.Helpers
{
    public static class Settings
    {
        private const string FirebaseUserToken = "FirebaseUserToken";

        public static void SaveToken(string token)
        {
            Preferences.Set(FirebaseUserToken, token);
            //await SecureStorage.Default.SetAsync(FirebaseUserToken, token);
        }

        public static string GetToken()
        {
            var token = Preferences.Get(FirebaseUserToken, string.Empty);
            //var token = await SecureStorage.Default.GetAsync(FirebaseUserToken);
            return token;
        }
    }
}

