using Goova.Subscriptions.Models.Dtos.Issuer;

namespace Goova.Subscriptions.Models.Dtos.Commerce
{
    public class CommerceDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CommerceNumber { get; set; }
        public string CommerceTerminalNumber { get; set; }
        public IssuerDto Issuer { get; set; }
    }
}
