namespace Goova.Subscriptions.Models.SubscriptionType
{
    public class SubscriptionType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Frequence Frequence { get; set; }
        public decimal SubscriptionBaseCost { get; set; } //Cost without taxes
        public string TaxPercentage { get; set; }
        public Currency Currency { get; set; }
        public bool PaidType { get; set; }
    }
}
