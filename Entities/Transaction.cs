using Goova.Subscriptions.Models.Enumerables;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Goova.Subscriptions.Models.Entities
{
    public class Transaction : BaseEntity
    {
        [Required]
        public int Id { get; set; }

        public string PlexoReferenceId { get; set; }

        [Required]
        public string SubscriptionName { get; set; }

        [Required]
        public string SubscriptionDescription { get; set; }

        [Required]
        public string SubscriptionToken { get; set; }

        [Required]
        public decimal TransactionAmount { get; set; }

        [Required]
        public int Currency { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        // could be null for free subscriptions
        public Instrument Instrument { get; set; }

        [Required]
        public TransactionStatus Status { get; set; }

        [Required]
        [DefaultValue(1)]
        public int RetryAttempt { get; set; } = 1;
        public ElectronicBill ElectronicBill { get; set; }//only for UY, client with billing enabled

        public int SubscriptorId { get;set; }
        public Subscriptor Subscriptor { get; set; }
    }
}
