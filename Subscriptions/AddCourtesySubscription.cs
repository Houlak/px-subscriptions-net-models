using Goova.Subscriptions.Models.Subscriptors;
using System;

namespace Goova.Subscriptions.Models.Subscriptions
{
    public class AddCourtesySubscription
    {
        public AddSubscriptorRequest addSubscriptorRequest { get; set; }
        public int SubscriptionTypeId { get; set; }
        public DateTime? ValidToDate { get; set; }
    }
}
