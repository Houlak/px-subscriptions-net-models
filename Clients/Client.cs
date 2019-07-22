using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients
{
    public class Client
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public ClientAdmin Admin { get; set; }
        public ICollection<SubscriptionTypeResponse> SubscriptionTypes { get; set; }
        public ICollection<Commerce> Commerces { get; set; }
        public ICollection<Consumer> Consumers { get; set; }
    }
}
