using System;

namespace Goova.Subscriptions.Models.Requests
{
    public class ClientAdmin
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public Guid ClientId { get; set; }
    }
}
