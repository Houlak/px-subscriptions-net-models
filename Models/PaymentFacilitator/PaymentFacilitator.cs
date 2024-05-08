using Goova.Subscriptions.Models.Requests.PaymentFacilitator;
using System;
using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Models.PaymentFacilitator
{
    public class PaymentFacilitator
    {
        public Guid Id { get; set; }
        public string CallbackUrl { get; set; }
        public string Name { get; set; }
        public Style Style { get; set; }
        public ICollection<PaymentFacilitatorCommerceId> PaymentFacilitatorCommerceIds { get; set; }
        public int PaymentFacilitatorPlexoId { get; set; }
        public PFAdmin PFadmin { get; set; }

    }
}
