﻿namespace Goova.Subscriptions.Models.Requests
{
    public class AddCommerceRequest
    {
        public string CommerceName { get; set; }
        public string CommerceNumber { get; set; }
        public string CommerceTerminalNumber { get; set; }
        public int IssuerId { get; set; }
        public int? PaymentFacilitatorPlexoCommerceId { get; set; }
        public string PFId { get; set; }
    }
}
