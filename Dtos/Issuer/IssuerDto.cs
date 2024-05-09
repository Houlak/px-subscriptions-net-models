using Plexo.Models;
using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Dtos.Issuer
{
    [System.Serializable]
    public class IssuerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string IssuerImageUrl { get; set; }
        public int PlexoId { get; set; }
        public bool Active { get; set; }
        public List<FieldInfo> Fields { get; set; }
    }
}
