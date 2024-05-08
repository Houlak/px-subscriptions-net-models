using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Models.PaymentFacilitator
{
    public class PaymentFacilitatorNotifications
    {
        public bool TransactionCancellation { get; set; }
        public bool SubscriptionCancellation { get; set; }
        public bool SubscriptorFields { get; set; }
        public bool PaymentSuccess { get; set; }
        public bool PaymentFailed { get; set; }
        public string CallbackUrl { get; set; }
    }
}
