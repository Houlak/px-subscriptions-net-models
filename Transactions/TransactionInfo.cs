using Goova.Subscriptions.Models.Payments;
using System;

namespace Goova.Subscriptions.Models.Transactions
{
    public class TransactionInfo
    {
        public int Id { get; set; }
        public string SubscriptionName { get; set; }
        public string SubscriptionDescription { get; set; }
        public string SubscriptionToken { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public TransactionState State { get; set; }
        public Currency Currency { get; set; }
        //public Instrument Instrument { get; set; } TODO: how to return instrument info on transaction
    }
}
