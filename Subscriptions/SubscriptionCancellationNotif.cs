using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Subscriptions
{
    public class SubscriptionCancellationNotif
    {
        public string SubscriptionType { get; set; }
        public string SubscriptionActulStatus {get; set;}
        public string ClientName { get; set; }
        public string CancellationDate { get; set; }
    }
}
