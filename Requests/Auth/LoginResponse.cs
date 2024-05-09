using Goova.Subscriptions.Models.Dtos.Account;

namespace Goova.Subscriptions.Models.Requests
{
    public class LoginResponse : Token
    {
        public AccountDto Account { get; set; }
    }
}
