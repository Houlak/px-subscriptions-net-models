using System;
using System.Collections.Generic;
using System.Text;
using Goova.Subscriptions.Models.Models.PaymentFacilitator;

namespace Goova.Subscriptions.Models.Requests.PaymentFacilitator
{
    public class EditPFRequest
    {
        public string Name { get; set; }
        public Style Style { get; set; }
        public List<PaymentFacilitatorCommerceId> PFCommerceIds { get; set; }
        public int PaymentFacilitatorPlexoId { get; set; }
        public int PFId { get; set; }

    }
}
