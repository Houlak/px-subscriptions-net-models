using Goova.Subscriptions.Models.Models.Account;

namespace Goova.Subscriptions.Models.Requests
{
    public class LoginResponse : Token
    {
        public Account Account { get; set; }
    }
}
