using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Goova.Subscriptions.Models.Entities
{
    public class ElectronicBill : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int  InternalId { get; set; }
        [Required]
        public string CAENumber { get; set; }
        [Required]
        public string Series { get; set; }
        [Required]
        public int Number { get; set; }
    }
}
