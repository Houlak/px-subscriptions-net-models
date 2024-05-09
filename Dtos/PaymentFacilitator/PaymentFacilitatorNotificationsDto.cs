namespace Goova.Subscriptions.Models.Dtos.PaymentFacilitator
{
    public class PaymentFacilitatorNotificationsDto
    {
        public bool TransactionCancellation { get; set; }
        public bool SubscriptionCancellation { get; set; }
        public bool SubscriptorFields { get; set; }
        public bool PaymentSuccess { get; set; }
        public bool PaymentFailed { get; set; }
        public string CallbackUrl { get; set; }
    }
}
