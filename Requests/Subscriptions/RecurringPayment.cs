using Goova.Subscriptions.Models.Models.Instruments;
using Goova.Subscriptions.Models.Models.Notifications;
using System;

namespace Goova.Subscriptions.Models.Requests.Subscriptions
{
    public class RecurringPayment : Notification
    {
        public string BillId { get; set; }
        public Instrument Instrument { get; set; }
        public string SubscriberName { get; set; }
        public decimal Amount { get; set; }
        public string PercentageTax { get; set; }
        public Currency Currency { get; set; }
        public DateTime PaymentDate { get; set; }
        public string ExternalId { get; set; }
        public string SubscriptionTypeId { get; set; }
        public string SubscriptionTypeName { get; set; }
        public string Authorization { get; set; }
        public string Ticket { get; set; }
        public bool Success { get; set; }
        public string ErrorString { get; set; }
    }
}
