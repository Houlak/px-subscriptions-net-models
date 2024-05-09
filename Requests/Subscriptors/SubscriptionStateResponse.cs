using Goova.Subscriptions.Models.Dtos.SubscriptionType;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Requests.Subscriptors
{
    public class SubscriptionStateResponse
    {
        public bool Active { get; set; }
        public SubscriptionTypeDto SubscriptionType { get; set; }
        public DateTime? ActiveUntil { get; set; }
    }
}
