namespace Goova.Subscriptions.Models.Requests
{
    public class Token
    {
        public string AccessToken { get; set; }
        public int ExpiresIn { get; set; }
    }
}
