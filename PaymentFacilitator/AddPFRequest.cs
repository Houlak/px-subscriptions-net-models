using System;
using System.Collections.Generic;

namespace Goova.Subscriptions.Models.PaymentFacilitator
{
    public class AddPFRequest
    {
        public string Name { get; set; }
        public Style Style { get; set; }
        public string AdminUserId { get; set; }
        public List<PaymentFacilitatorCommerceId> PFCommerceIds { get; set; }
        public int PaymentFacilitatorPlexoId { get; set; }
    }
}
