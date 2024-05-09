using Goova.Subscriptions.Models.Enumerables;

namespace Goova.Subscriptions.Models.Requests.SubscriptionType
{
    public class AddSubscriptionTypeRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Frequence Frequence { get; set; }
        public decimal SubscriptionCost { get; set; }
        public Currency Currency { get; set; }
        public bool RegularType { get; set; } = true;
        public int Recurrence { get; set; } //If is equal to zero is disable
    }
}
