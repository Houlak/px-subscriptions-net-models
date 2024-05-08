namespace Goova.Subscriptions.Models.Requests.PaymentFacilitatorIssuers
{
    public class AddPFIssuerRequest
    {
        public int IssuerId { get; set; }
        public string Name { get; set; }
        public string PFId { get; set; }
    }
}
