using System;

namespace Goova.Subscriptions.Models.Subscriptors
{
    public class SubscriptorsQueryAttribute
    {
        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 5;
        public string SubscriptorEmailOrNameOrId { get; set; }
        public SubscriptorsQueryState SubscriptorsState { get; set; }
        public string SubscriptionTypes { get; set; }
    }

    public enum SubscriptorsQueryState
    {
        All,
        Active,
        Inactive
    }
}
