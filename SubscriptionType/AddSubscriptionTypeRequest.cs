namespace Goova.Subscriptions.Models.SubscriptionType
{
    public class AddSubscriptionTypeRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Frequence Frequence { get; set; }
        public decimal SubscriptionCost { get; set; }
        public Currency Currency { get; set; }
        public bool Visible { get; set; }
    }
}
