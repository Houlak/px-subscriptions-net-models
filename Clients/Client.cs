﻿using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Clients
{
    public class Client
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string LegalName { get; set; }
        public string LegalId { get; set; }
        public ClientAdmin Admin { get; set; }
        public ICollection<SubscriptionType.SubscriptionType> SubscriptionTypes { get; set; }
        public ICollection<Commerce.Commerce> Commerces { get; set; }
        public ICollection<Subscriptors.Subscriptor> Subscriptors { get; set; }
    }
}
