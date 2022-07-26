using System;
namespace MyMoney.Services
{
    public interface IFirebaseAuthService
    {
        void SingIn(string email, string password);
        void SingUp(string name, string email, string password);
    }

    public class FirebaseAuthService : IFirebaseAuthService
    {
        public void SingIn(string email, string password)
        {
            
        }

        public void SingUp(string name, string email, string password)
        {
            
        }
    }
}

