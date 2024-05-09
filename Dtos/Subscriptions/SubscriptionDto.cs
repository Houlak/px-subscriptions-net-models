using Goova.Subscriptions.Models.Dtos.SubscriptionType;
using Goova.Subscriptions.Models.Dtos.Transactions;
using Goova.Subscriptions.Models.Enumerables;
using System;

namespace Goova.Subscriptions.Models.Dtos.Subscriptions
{
    public class SubscriptionDto
    {
        public string Id { get; set; }
        public string Token { get; set; }
        public string LegalId { get; set; } //Legal id of subscriptor in case of reduce iva
        public SubscriptionTypeDto SubscriptionType { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public TransactionState SubscriptionStatus { get; set; }
        public DateTime SubscriptionLastPaymentDate { get; set; }
        public DateTime ValidUntil { get; set; }
        public int RemainingRecurrences { get; set; }
    }
}
