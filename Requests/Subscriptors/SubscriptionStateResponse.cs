using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Requests.Subscriptors
{
    public class SubscriptionStateResponse
    {
        public bool Active { get; set; }
        public Models.SubscriptionType.SubscriptionType SubscriptionType { get; set; }
        public DateTime? ActiveUntil { get; set; }
    }
}
