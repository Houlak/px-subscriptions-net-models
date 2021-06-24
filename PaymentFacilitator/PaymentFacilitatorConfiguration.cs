using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Goova.Subscriptions.Models.PaymentFacilitator
{
    public class PaymentFacilitatorConfiguration
    {
        public PaymentFacilitatorDto PaymentFacilitator { get; set; }
        public bool Enabled { get; set; }
        public bool CanCreateAdditionalIssuers { get; set; }
        public int PFCommerceId { get; set; }
        public PaymentFacilitatorConfiguration() : base()
        {

        }
    }
}
