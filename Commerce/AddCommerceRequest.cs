namespace Goova.Subscriptions.Models.Commerce
{
    public class AddCommerceRequest
    {
        public string CommerceName { get; set; }
        public string CommerceNumber { get; set; }
        public string CommerceTerminalNumber { get; set; }
        public int IssuerId { get; set; }
        public int? PaymentFacilitatorPlexoCommerceId { get; set; }
    }
}
