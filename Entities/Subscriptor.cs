using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Goova.Subscriptions.Models.Entities
{
    public class Subscriptor : BaseEntity
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string ExternalId { get; set; }
        
        public string Email { get; set; }
        
        public string Name { get; set; }

        public string PostalCode { get; set; }
        
        public string FullName { get; set; }

        [Required]
        public Guid ClientId { get; set; }

        public ICollection<Instrument> Instruments { get; set; }
        
        public ICollection<Subscription> Subscriptions { get; set; }
        
        public ICollection<Transaction> Transactions { get; set; }
    }
}
