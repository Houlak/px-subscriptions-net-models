using Goova.Subscriptions.Models.ElectronicBilling;
using Goova.Subscriptions.Models.Transactions;
using System;


namespace Goova.Subscriptions.Models.Notifications
{
    public class TrnCancellationNotification : Notification
    {
        public int Id { get; set; }
        public string PlexoReferenceId { get; set; }
        public Guid ClientId { get; set; }
        public int SubscriptorId { get; set; }
        public string SubscriptorExternalId { get; set; }
        public int? SubscriptionTypeId { get; set; } = null;
        public string SubscriptionName { get; set; }
        public string SubscriptionDescription { get; set; }
        public string SubscriptionToken { get; set; }
        public decimal TransactionAmount { get; set; }
        public int Currency { get; set; }
        public DateTime TransactionDate { get; set; }
        public Guid InstrumentId { get; set; }
        public Guid InstrumentToken { get; set; }
        public string Name { get; set; }
        public string IssuerName { get; set; }
        public TransactionState Status { get; set; }
        public string ElectronicBillingId { get; set; } //UUID de factura generada con FacturaEnLinea (MX)
        public ElectronicBill ElectronicBillUY { get; set; } //UUID de factura generada con FacturaEnLinea (MX)
        public new NotificationTypeEnum NotificationType { get; } = NotificationTypeEnum.TransactionCancellation;
    }
}
