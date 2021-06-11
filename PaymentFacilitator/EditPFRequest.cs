using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.PaymentFacilitator
{
    public class EditPFRequest
    {
        public string Name { get; set; }
        public Style Style { get; set; }
        public List<int> PFCommerceIds { get; set; }
        public int PaymentFacilitatorPlexoId { get; set; }
        public int PFId { get; set; }

    }
}
