using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.SubscriptionType
{
    public class SubscriptionType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Frequence Frequence { get; set; }
        public decimal SubscriptionCost { get; set; }
        public Currency Currency { get; set; }
    }

    public enum Frequence
    {
        Diary,
        Weekly,
        Monthly,
        Bimonthly,
        Quaterly,
        Biannual,
        Annual
    }

    public enum Currency
    {
        UruguayanPeso = 1,
        Dollar = 2,
        MexicanPeso = 6,
    }
}
