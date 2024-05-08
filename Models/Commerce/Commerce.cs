namespace Goova.Subscriptions.Models.Models.Commerce
{
    public class Commerce
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CommerceNumber { get; set; }
        public string CommerceTerminalNumber { get; set; }
        public Issuer.Issuer Issuer { get; set; }
    }
}
