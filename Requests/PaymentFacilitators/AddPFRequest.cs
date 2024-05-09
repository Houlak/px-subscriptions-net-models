using System;
using System.Collections.Generic;
using Goova.Subscriptions.Models.Dtos.PaymentFacilitator;

namespace Goova.Subscriptions.Models.Requests.PaymentFacilitator
{
    public class AddPFRequest
    {
        public string Name { get; set; }
        public StyleDto Style { get; set; }
        public string AdminUserId { get; set; }
        public List<PaymentFacilitatorCommerceIdDto> PFCommerceIds { get; set; }
        public int PaymentFacilitatorPlexoId { get; set; }
    }
}
