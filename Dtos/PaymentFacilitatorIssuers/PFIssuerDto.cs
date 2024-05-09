using Goova.Subscriptions.Models.Dtos.Issuer;

namespace Goova.Subscriptions.Models.Dtos.PaymentFacilitatorIssuers
{
    public class PFIssuerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IssuerDto Issuer { get; set; }
    }
}
