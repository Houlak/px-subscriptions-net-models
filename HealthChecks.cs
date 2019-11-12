using System.Collections.Generic;

namespace Goova.Subscriptions.Models
{
    public class HealthResponse
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public List<HealthError> Errors { get; set; }
    }

    public class HealthError
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
