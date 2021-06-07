using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.PaymentFacilitator
{
    public class PaymentFacilitator
    {
        public Guid Id { get; set; }
        public string CallbackUrl { get; set; }
        public string Name { get; set; }
        public Style Style { get; set; }
        public ICollection<int> PaymentFacilitatorCommerceIds { get; set; }
        public int PaymentFacilitatorPlexoId { get; set; }

    }
}
