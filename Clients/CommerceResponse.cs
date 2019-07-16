using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Suscriptions.Models.Clients
{
    public class CommerceResponse
    {
        public bool IsSuccess { get; set; }
        public int? CommerceId { get; set; }
        public string Message { get; set; }
    }
}
