using Goova.Subscriptions.Models.Enumerables;

namespace Goova.Subscriptions.Models.Dtos.SubscriptionType
{
    public class SubscriptionTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Frequence Frequence { get; set; }
        public decimal SubscriptionBaseCost { get; set; } //Cost without taxes
        public string TaxPercentage { get; set; }
        public Currency Currency { get; set; }
        public bool RegularType { get; set; }
        public int Recurrence { get; set; }
    }
}
