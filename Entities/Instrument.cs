using System.ComponentModel.DataAnnotations;

namespace Goova.Subscriptions.Models.Entities
{
    public class Instrument : BaseEntity
    {
        [Required]
        public System.Guid Id { get; set; }

        [Required]
        public int SubscriptorId { get; set; }

        public Subscriptor Subscriptor { get; set; }

        [Required]
        public System.Guid InstrumentToken { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string IssuerName { get; set; }

        [Required]
        public string IssuerImageUrl { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public System.DateTime Expiration { get; set; }

        [Required]
        public int Status { get; set; }

        public string Metadata { get; set; }

        public string PlexoExtendedResponse { get; set; }

    }
}
