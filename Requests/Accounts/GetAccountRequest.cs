using Goova.Subscriptions.Models.Enumerables;
using System;

namespace Goova.Subscriptions.Models.Requests.Accounts.GetAccountRequest
{
    public class GetAccountRequest
    {
        public Guid UserId { get; set; }
        public UserType UserType { get; set; }
    }
}
