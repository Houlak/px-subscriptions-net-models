using Goova.Subscriptions.Models.Dtos.ElectronicBilling;
using Goova.Subscriptions.Models.Dtos.Instruments;
using Goova.Subscriptions.Models.Dtos.Subscriptions;
using Goova.Subscriptions.Models.Dtos.Subscriptors;
using Goova.Subscriptions.Models.Enumerables;
using System;

namespace Goova.Subscriptions.Models.Dtos.Transactions
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public SubscriptionDto Subscription { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public TransactionState State { get; set; }
        public Currency Currency { get; set; }
        public InstrumentDto Instrument { get; set; }
        public SubscriptorDto Subscriptor { get; set; }
        public ElectronicBillDto ElectronicBill { get; set; }
    }
}
