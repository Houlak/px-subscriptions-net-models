using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Goova.Subscriptions.Models.Entities
{
    public class PaymentFacilitatorConfiguration : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public PaymentFacilitator PaymentFacilitator { get; set; }
        public bool Enabled { get; set; }
        public bool CanCreateAdditionalIssuers { get; set; }
        public Client Client { get; set; }

        public Guid ClientId { get; set; } //necessary for foreign key
        public int PaymentFacilitatorCommerceId {get;set ;}
        public PaymentFacilitatorConfiguration() : base()
        {

        }
    }
}
