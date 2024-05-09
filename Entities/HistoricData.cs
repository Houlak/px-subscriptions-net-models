using System;
using System.ComponentModel.DataAnnotations;

namespace Goova.Subscriptions.Models.Entities
{
    public class HistoricData
    {
        [Required]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int TotalSubscriptors { get; set; }
    }
}
