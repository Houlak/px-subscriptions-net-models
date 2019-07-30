using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Subscriptors
{
    public class SubscribeUserRequest
    {
        public string ExternalId { get; set; }
        public int SubscriptionTypeId { get; set; }
        public Guid InstrumentId { get; set; }
    }
}
