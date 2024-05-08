using Goova.Subscriptions.Models.Models.ElectronicBilling;
using Goova.Subscriptions.Models.Models.Instruments;
using Goova.Subscriptions.Models.Models.Subscriptions;
using Goova.Subscriptions.Models.Requests.Subscriptors;
using System;

namespace Goova.Subscriptions.Models.Models.Transactions
{
    public class Transaction
    {
        public int Id { get; set; }
        public Subscription Subscription { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public TransactionState State { get; set; }
        public Currency Currency { get; set; }
        public Instrument Instrument { get; set; }
        public SubscriptorDTO Subscriptor { get; set; }
        public ElectronicBill ElectronicBill { get; set; }
    }

    public enum TransactionState
    {
        Ok = 0,
        OnHold = 1,
        Canceled = 2,
        CancelationFailed = 3,
        Failed = 4,
    }
}
