using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Goova.Subscriptions.Models.Entities
{
    public class PaymentFacilitator : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CallbackUrl { get; set; }
        public Style Style { get; set; }
        public ApplicationUser Admin { get; set; }
        public ICollection<PaymentFacilitatorCommerceId> PaymentFacilitatorCommerceIds { get; set; }
        public int PaymentFacilitatorPlexoId { get; set; }

        public ICollection<PaymentFacilitatorConfiguration> PaymentFacilitatorConfigurations { get; set; }
        public ICollection<PaymentFacilitatorIssuer> PaymentFacilitatorIssuers { get; set; }

        public NotificationPermissions NotificationPermissions { get; set; }

        public PaymentFacilitator() : base()
        {

        }
    }
}
