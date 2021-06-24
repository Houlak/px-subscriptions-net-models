using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.PaymentFacilitator
{
    public class PaymentFacilitatorCommerceId
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public PaymentFacilitator PaymentFacilitator { get; set; }
    }
}
