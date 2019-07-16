namespace Goova.Subscriptions.Models
{
    public class Token
    {
        public string UserId { get; set; }
        public string AccessToken { get; set; }
        public int ExpiresIn { get; set; }
    }
}
