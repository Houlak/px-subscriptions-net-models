using Goova.Subscriptions.Models.Instruments;
using Goova.Subscriptions.Models.Transactions;
using System;

namespace Goova.Subscriptions.Models.Subscriptions
{
    public class Subscription
    {
        public string Id { get; set; }
        public string Token { get; set; }
        public SubscriptionType.SubscriptionType SubscriptionType { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public TransactionState SubscriptionStatus { get; set; }
        public DateTime SubscriptionLastPaymentDate { get; set; }
        public DateTime ValidUntil { get; set; }
    }
}
