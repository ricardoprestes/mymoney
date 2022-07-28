using Firebase.Auth;
using MyMoney.Helpers;

namespace MyMoney.Services
{
    public interface IFirebaseAuthService
    {
        Task<FirebaseAuth> SingIn(string email, string password);
        Task<FirebaseAuth> SingUp(string name, string email, string password);
        Task<FirebaseAuth> RefreshAuth(FirebaseAuth firebaseAuth);
    }

    public class FirebaseAuthService : IFirebaseAuthService
    {
        private readonly FirebaseAuthProvider _provider;

        public FirebaseAuthService()
        {
            _provider = new FirebaseAuthProvider(new FirebaseConfig(Constants.FirebaseWebApiKey));
        }

        public async Task<FirebaseAuth> RefreshAuth(FirebaseAuth firebaseAuth)
        {
            var auth = await _provider.RefreshAuthAsync(firebaseAuth);
            return auth;
        }

        public async Task<FirebaseAuth> SingIn(string email, string password)
        {
            var auth = await _provider.SignInWithEmailAndPasswordAsync(email, password);
            return auth;
        }

        public async Task<FirebaseAuth> SingUp(string name, string email, string password)
        {
            var auth = await _provider.CreateUserWithEmailAndPasswordAsync(email, password, displayName: name);
            return auth;
        }
    }
}

