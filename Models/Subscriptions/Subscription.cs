using Goova.Subscriptions.Models.Models.Transactions;
using System;

namespace Goova.Subscriptions.Models.Models.Subscriptions
{
    public class Subscription
    {
        public string Id { get; set; }
        public string Token { get; set; }
        public string LegalId { get; set; } //Legal id of subscriptor in case of reduce iva
        public SubscriptionType.SubscriptionType SubscriptionType { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public TransactionState SubscriptionStatus { get; set; }
        public DateTime SubscriptionLastPaymentDate { get; set; }
        public DateTime ValidUntil { get; set; }
        public int RemainingRecurrences { get; set; }
    }
}
