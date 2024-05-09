using Goova.Subscriptions.Models.Enumerables;
using System;
using System.ComponentModel.DataAnnotations;

namespace Goova.Subscriptions.Models.Entities
{
    public class Subscription : BaseEntity
    {
        [Required]
        public Guid Id { get; set; }

        public string CiberSourceFingerprint { get; set; } //visa payments

        [Required]
        public string Token { get; set; }

        public SubscriptionType SubscriptionType { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime SubscriptionDate { get; set; }

        [Required]
        public SubscriptionStatus SubscriptionStatus { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime LastPaymentDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ValidToDate { get; set; }

        public string ClientLegalId { get; set; }

        public string BackgroundJobId { get; set; }

        public int SubscriptorId { get; set; }
        public Subscriptor Subscriptor { get; set; }

        public SuspendedByEnum? SuspendedBy { get; set; } = null;

        [DataType(DataType.Date)]
        public DateTime? SuspendedDate { get; set; } = null;
    }
}
