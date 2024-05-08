using Goova.Subscriptions.Models.Models.ElectronicBilling;
using Goova.Subscriptions.Models.Models.Instruments;
using Goova.Subscriptions.Models.Models.Subscriptions;
using Goova.Subscriptions.Models.Models.Transactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Requests.Transactions
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public Subscription Subscription { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public TransactionState State { get; set; }
        public Currency Currency { get; set; }
        public Instrument Instrument { get; set; }
        public Subscriptors.SubscriptorDTO Subscriptor { get; set; }
        public ElectronicBill ElectronicBill { get; set; }
        public string PlexoTransactionId { get; set; }
        public string IssuerAuthCode { get; set; }
        public string ErrorText { get; set; }
        public string ErrorCode { get; set; }
    }
}
