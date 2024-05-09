using Goova.Subscriptions.Models.Dtos.Instruments;
using Goova.Subscriptions.Models.Dtos.Notifications;
using Goova.Subscriptions.Models.Enumerables;
using System;

namespace Goova.Subscriptions.Models.Requests.Subscriptions
{
    public class RecurringPayment : NotificationDto
    {
        public string BillId { get; set; }
        public InstrumentDto Instrument { get; set; }
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
