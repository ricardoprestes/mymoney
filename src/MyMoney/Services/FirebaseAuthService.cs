using System;
using Firebase.Auth;
using MyMoney.Helpers;

namespace MyMoney.Services
{
    public interface IFirebaseAuthService
    {
        void SingIn(string email, string password);
        Task<string> SingUp(string name, string email, string password);
    }

    public class FirebaseAuthService : IFirebaseAuthService
    {
        public void SingIn(string email, string password)
        {
            
        }

        public async Task<string> SingUp(string name, string email, string password)
        {
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(Constants.FirebaseWebApiKey));
            var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password, displayName: name);
            var token = auth.FirebaseToken;
            return token;
        }
    }
}

