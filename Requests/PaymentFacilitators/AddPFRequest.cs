using System;
using System.Collections.Generic;
using Goova.Subscriptions.Models.Models.PaymentFacilitator;

namespace Goova.Subscriptions.Models.Requests.PaymentFacilitator
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
