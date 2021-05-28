using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients
{
    public class GetConfiguration
    {
        public bool TransactionCancellation { get; set; }
        public bool SubscriptionCancellation { get; set; }
        public bool SubscriptorFields { get; set; }
        public bool PaymentSuccess { get; set; }
        public bool PaymentFailed { get; set; }
        public string CallbackUrl { get; set; }
        public  RetriesConfigurationEnum RetriesConfiguration { get; set; }
    }
}
