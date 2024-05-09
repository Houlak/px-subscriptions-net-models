using System.ComponentModel.DataAnnotations;

namespace Goova.Subscriptions.Models.Entities
{
    public class ClientIssuer : BaseEntity
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string CommerceNumber { get; set; }
        
        public string CommerceTerminalNumber { get; set; }
        
        [Required]
        public Issuer Issuer { get; set; }

    }
}
