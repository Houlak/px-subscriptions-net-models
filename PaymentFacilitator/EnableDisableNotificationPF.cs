using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.PaymentFacilitator
{
    public class EnableDisableNotificationPF
    {
        public bool TransactionCancellation { get; set; }
        public bool SubscriptionCancellation { get; set; }
        public bool SubscriptorFields { get; set; }
        public bool PaymentSuccess { get; set; }
        public bool PaymentFailed { get; set; }
        public string CallbackUrl { get; set; }
        public Goova.Subscriptions.Models.Clients.RetriesConfigurationEnum RetriesConfiguration { get; set; }
        public bool OnlyNotifications { get; set; } = false;
    }
}
