namespace Goova.Subscriptions.Models.Requests.PaymentFacilitator
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
