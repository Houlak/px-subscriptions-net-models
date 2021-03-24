using System;

namespace Goova.Subscriptions.Models.Account
{
    public class GetAccountRequest
    {
        public Guid UserId { get; set; }
        public UserType UserType { get; set; }
    }
}
