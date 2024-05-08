using System;
using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Requests.PaymentFacilitator
{
    public class PaymentFacilitatorDetails
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<int> PaymentFacilitatorCommerceIds { get; set; }
        public int PaymentFacilitatorPlexoId { get; set; }
    }
}
