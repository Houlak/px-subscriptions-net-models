using Goova.Subscriptions.Models.Clients;
using Goova.Subscriptions.Models.Instruments;
using System;

namespace Goova.Subscriptions.Models.Subscriptors
{
    public class SubscriptionInfo
    {
        public string Id { get; set; }
        public string Token { get; set; }
        public SubscriptionTypeResponse SubscriptionType { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public TransactionState SubscriptionStatus { get; set; }
        public DateTime SubscriptionLastPaymentDate { get; set; }
        public Instrument PaymentInstrument { get; set; }
    }
}
