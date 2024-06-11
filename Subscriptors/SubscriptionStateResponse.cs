using Goova.Subscriptions.Models.Transactions;
using System;

namespace Goova.Subscriptions.Models.Subscriptors
{
    public class SubscriptionStateResponse
    {
        public bool Valid { get; set; }
        public SubscriptionType.SubscriptionType SubscriptionType { get; set; }
        public DateTime? ActiveUntil { get; set; }
        public TransactionState SubscriptionStatus { get; set; }
    }
}
