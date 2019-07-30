using System;

namespace Goova.Subscriptions.Models.Subscriptors
{
    public class SubscriptorsQueryAttribute
    {
        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 5;
    }
}
