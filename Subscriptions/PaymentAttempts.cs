using Goova.Subscriptions.Models.Transactions;
using System;

namespace Goova.Subscriptions.Models.Subscriptions
{
    public class PaymentAttempts
    {
        public int TimesAttempted { get; set; }
        public string ExternalId { get; set; }
        public int SubscriptionTypeId { get; set; }
    }
}
