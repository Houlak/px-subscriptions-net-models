namespace Goova.Subscriptions.Models.Requests.Subscriptors
{
    public class AddSubscriptorRequest
    {
        public string ExternalId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public string FullName { get; set; }
    }
}
