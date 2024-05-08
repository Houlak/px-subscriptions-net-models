namespace Goova.Subscriptions.Models.Requests.Subscriptors
{
    public class SubscriptorDTO
    {
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public string FullName { get; set; }
    }
}
