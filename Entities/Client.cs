using Goova.Subscriptions.Models.Enumerables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Goova.Subscriptions.Models.Entities
{
    public class Client : BaseEntity
    {
        [Required]
        public Guid Id { get; set; }
        
        [Required]
        [StringLength(30,ErrorMessage = "Name should be maxium 30 characters")]
        public string Name { get; set; }
        
        [Required]
        public string LegalName { get; set; }
        
        [Required]
        public string LegalId { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "ClientSecret should be maxium 50 characters")]
        public string ClientSecret { get; set; }
        
        [Required]
        public int CommerceId { get; set; }

        public string RecurringPaymentUrl { get; set; }

        [Required]
        public ApplicationUser Admin { get; set; }
        
        public ICollection<SubscriptionType> SubscriptionTypes { get; set; }
        
        public ICollection<ClientIssuer> ClientIssuers { get; set; }
        
        public ICollection<Subscriptor> Subscriptors { get; set; }
        public ICollection<HistoricData> HistoricData { get; set; }

        public bool ElectronicBillingEnabled { get; set; }

        public RetriesConfigurationEnum RetriesConfiguration { get; set; } 

        public NotificationPermissions NotificationPermissions { get; set; }
        public PaymentFacilitatorConfiguration PFConfiguration { get; set; }

        public bool TaxApplies { get; set; }
    }
}
