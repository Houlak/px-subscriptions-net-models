using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Subscriptors
{
    public class SubscriptionStateResponse
    {
        public bool Active { get; set; }
        public SubscriptionType.SubscriptionType SubscriptionType { get; set; }
        public DateTime? ActiveUntil { get; set; }
    }
}
