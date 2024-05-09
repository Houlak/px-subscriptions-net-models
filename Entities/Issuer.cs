using System.ComponentModel.DataAnnotations;

namespace Goova.Subscriptions.Models.Entities
{
    public class Issuer : BaseEntity
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        [StringLength(40, ErrorMessage = "Issuer image should be maxium 40 characters")]
        public string Name { get; set; }
        
        [Required]
        public string NormalizedName { get; set; }
        
        public string ImageUrl { get; set; }
        
        [Required]
        public int PlexoId { get; set; }
        
        [Required]
        public bool Active { get; set; }
    }
}
