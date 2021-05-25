using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients
{
    public class SetNotificationPermissions
    {
        public int? Id { get; set; } = null;
        public bool TransactionCancellation { get; set; }
        public bool SubscriptionCancellation { get; set; }
        public bool SubscriptorFields { get; set; }
        public bool PaymentSuccess { get; set; }
        public bool PaymentFailed { get; set; }
    }
}
