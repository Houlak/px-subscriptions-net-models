namespace Goova.Subscriptions.Models
{
    public class LoginResponse : Token
    {
        public Account.Account Account { get; set; }
    }

    public enum UserType
    {
        SuperAdmin = 0,
        Admin = 1,
    }
}
