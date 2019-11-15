namespace Goova.Subscriptions.Models.Issuers
{
    [System.Serializable]
    public class Issuer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string IssuerImageUrl { get; set; }
        public int PlexoId { get; set; }
        public bool Active { get; set; }
    }
}
