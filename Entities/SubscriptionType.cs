using Goova.Subscriptions.Models.Enumerables;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Goova.Subscriptions.Models.Entities
{
    public class SubscriptionType : BaseEntity
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50,ErrorMessage = "SubscriptionType Name should be maxium 50 characters")]
        public string Name { get; set; }

        [Required]
        [StringLength(120, ErrorMessage = "SubscriptionType Name should be maxium 120 characters")]
        public string Description { get; set; }

        [Required]
        public Frequence Frequence { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,10)")]
        public decimal Cost { get; set; }

        [Required]
        public Currency Currency { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public bool RegularType { get; set; } = true;

        [Required]
        public int Recurrence { get; set; } = 0; //If is equal to zero is disable

    }
}
