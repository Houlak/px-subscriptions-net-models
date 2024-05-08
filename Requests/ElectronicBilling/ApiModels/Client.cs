namespace Goova.Subscriptions.Models.Requests.ElectronicBilling.ApiModels
{
    public class Client // Mandante
    {
        public DocType DocType { get; set; } = DocType.Unknown; //Hardcoded 4
        public long DocNumber { get; set; }
        public string SocialReason { get; set; }
    }
}
