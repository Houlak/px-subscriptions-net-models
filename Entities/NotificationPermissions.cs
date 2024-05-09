using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Goova.Subscriptions.Models.Entities
{
    public class NotificationPermissions: BaseEntity
    {
        [Required]
        public int Id { get; set; }
        public bool TransactionCancellation { get; set; }
        public bool SubscriptionCancellation { get; set; }
        public bool SubscriptorFields { get; set; }
        public bool PaymentSuccess { get; set; }
        public bool PaymentFailed { get; set; }
    }
}
