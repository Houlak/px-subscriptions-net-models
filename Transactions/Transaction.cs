using Goova.Subscriptions.Models.Instruments;
using Goova.Subscriptions.Models.SubscriptionType;
using System;

namespace Goova.Subscriptions.Models.Transactions
{
    public class Transaction
    {
        public int Id { get; set; }
        public Subscriptions.Subscription Subscription { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public TransactionState State { get; set; }
        public Currency Currency { get; set; }
        public Instrument Instrument { get; set; }
        public Subscriptors.SubscriptorDTO Subscriptor { get; set; }
    }

    public enum TransactionState
    {
        Ok = 0,
        OnHold = 1,
        Canceled = 2,
        Failed = 4,
    }
}
