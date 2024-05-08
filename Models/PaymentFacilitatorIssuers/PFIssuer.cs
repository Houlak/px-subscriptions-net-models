namespace Goova.Subscriptions.Models.Models.PaymentFacilitatorIssuers
{
    public class PFIssuer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Models.Issuer.Issuer Issuer { get; set; }
    }
}
