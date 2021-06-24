using Goova.Subscriptions.Models.Notifications;
using Goova.Subscriptions.Models.Transactions;
using System;

namespace Goova.Subscriptions.Models.Subscriptions
{
    public class PaymentAttempts : Notification
    {
        public int TimesAttempted { get; set; }
        public string ExternalId { get; set; }
        public int SubscriptionTypeId { get; set; }

        public string SubscriptionTypeName { get; set; }
        
        
    }
}
