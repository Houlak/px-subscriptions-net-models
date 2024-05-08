using System;
using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Requests.PaymentFacilitator
{
    public class AddPFCommerceId
    {
        public string PFId { get; set; }
        public int PFCommerceId { get; set; }
    }
}
