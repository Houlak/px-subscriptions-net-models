using Goova.Subscriptions.Models.Issuers;

namespace Goova.Subscriptions.Models.PaymentFacilitatorIssuers
{
    public class PFIssuer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Issuer Issuer { get; set; }
    }
}
