using System;

namespace Goova.Subscriptions.Models.Subscriptions
{
    public class RecurringPayment
    {
        public string BillId { get; set; }
        public bool Success { get; set; }
        public Instruments.Instrument Instrument { get; set; }
        public string SubscriberName { get; set; }
        public decimal Amount { get; set; }
        public string PercentageTax { get; set; }
        public Currency Currency { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
