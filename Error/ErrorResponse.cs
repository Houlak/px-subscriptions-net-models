using System.Net;

namespace Goova.Subscriptions.Models.Error
{
    public class ErrorResponse
    {
        public HttpStatusCode Code { get; set; }
        public string Message { get; set; }
        public int SubCode { get; set; }
    }
}
