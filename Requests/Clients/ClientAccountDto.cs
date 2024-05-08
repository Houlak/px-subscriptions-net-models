using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Requests
{
    public class ClientAccountDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool ElectronicBillingEnabled { get; set; }
        public int? PaymentFacilitatorCommerceId {get;set;}
        public bool CanCreateAdditionalIssuers { get; set; }

    }

}
