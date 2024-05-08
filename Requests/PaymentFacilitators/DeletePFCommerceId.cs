using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Requests.PaymentFacilitator
{
    public class DeletePFCommerceId
    {
        public string PFId { get; set; }
        public int PFCommerceId { get; set; }
    }
}
