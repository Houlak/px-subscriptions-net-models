namespace Goova.Subscriptions.Models.Requests.PaymentFacilitatorIssuers
{
    public class DeletePFIssuerRequest
    {
        public int IssuerId { get; set; }
        public string PFId { get; set; }
    }
}
