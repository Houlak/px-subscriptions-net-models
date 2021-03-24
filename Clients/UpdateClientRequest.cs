namespace Goova.Subscriptions.Models.Clients
{
    public class UpdateClientRequest
    {
        public string ClientName { get; set; }
        //public string ClientSecret { get; set; }
        public string RecurringPaymentUrl { get; set; }
        public string LegalName { get; set; }
        public bool ElectronicBillingEnabled { get; set; }
    }
}
