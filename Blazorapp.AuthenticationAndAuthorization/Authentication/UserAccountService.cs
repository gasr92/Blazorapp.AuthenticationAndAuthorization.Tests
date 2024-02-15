namespace Blazorapp.AuthenticationAndAuthorization.Authentication
{
    public class UserAccountService
    {
        public UserAccount? GetByUsername(string username)
        {
            return Users.FirstOrDefault(x => x.Username == username);
        }

        private List<UserAccount> Users => new()
        {
            new UserAccount{Username = "admin", Password = "admin", Role = "Administrator"},
            new UserAccount{Username = "user", Password = "user", Role = "User"},
        };
    }
}
