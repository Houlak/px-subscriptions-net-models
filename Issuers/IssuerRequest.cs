using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Issuers
{
    public class IssuerRequest
    {
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string PictureUri { get; set; }
        public int PlexoId { get; set; }
        public bool Active { get; set; }
    }
}
