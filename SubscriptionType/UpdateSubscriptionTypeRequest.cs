namespace Goova.Subscriptions.Models.SubscriptionType
{
    public class UpdateSubscriptionTypeRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SubscriptionCost { get; set; }
    }
}
