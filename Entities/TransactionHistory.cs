using Goova.Subscriptions.Models.Enumerables;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Goova.Subscriptions.Models.Entities
{
    public class TransactionHistory : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string PlexoReferenceId { get; set; }
        public System.Guid ClientId { get; set; }
        public int SubscriptorId { get; set; }
        public string SubscriptorExternalId { get; set; }
        public int? SubscriptionTypeId { get; set; } = null;
        public string SubscriptionName { get; set; }
        public string SubscriptionDescription { get; set; }
        public string SubscriptionToken { get; set; }
        public decimal TransactionAmount { get; set; }
        public int Currency { get; set; }
        public DateTime TransactionDate { get; set; }
        public System.Guid InstrumentId { get; set; }
        public System.Guid InstrumentToken { get; set; }
        public string Name { get; set; }
        public string IssuerName { get; set; }
        public TransactionStatus Status { get; set; }
        public string ElectronicBillingId { get; set; } //UUID de factura generada con FacturaEnLinea (MX)
        public ElectronicBill ElectronicBillUY { get; set; } //UUID de factura generada con FacturaEnLinea (MX)
        public string IssuerAuthCode { get; set; }
        public string ErrorText { get; set; }
        public string ErrorCode { get; set; }
    }
}
