namespace Goova.Subscriptions.Models
{
    public class LoginResponse : Token
    {
        public UserType UserType { get; set; }
    }

    public enum UserType
    {
        SuperAdmin = 0,
        Admin = 1,
    }
}
