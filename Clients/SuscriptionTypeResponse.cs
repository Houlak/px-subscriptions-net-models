using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Suscriptions.Models.Clients
{
    public class SuscriptionTypeResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public SuscriptionFrequence Frequence { get; set; }
        public double SuscriptionCost { get; set; }
    }
}
