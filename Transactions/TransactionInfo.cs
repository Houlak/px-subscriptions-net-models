using System;

namespace Goova.Subscriptions.Models.Transactions
{
    public class TransactionInfo
    {
        public int Id { get; set; }
        public string SubscriptionName { get; set; }
        public string SubscriptionDescription { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        //public Instrument Instrument { get; set; } TODO: how to return instrument info on transaction
    }
}
