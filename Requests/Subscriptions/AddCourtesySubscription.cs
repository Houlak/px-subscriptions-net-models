using Goova.Subscriptions.Models.Requests.Subscriptors;
using System;

namespace Goova.Subscriptions.Models.Requests.Subscriptions
{
    public class AddCourtesySubscription
    {
        public AddSubscriptorRequest addSubscriptorRequest { get; set; }
        public int SubscriptionTypeId { get; set; }
        public DateTime? ValidToDate { get; set; }
    }
}
