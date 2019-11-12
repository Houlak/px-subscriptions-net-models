namespace Goova.Subscriptions.Models.Subscriptors
{
    public class AddSubscriptorRequest
    {
        public string ExternalId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
    }
}
