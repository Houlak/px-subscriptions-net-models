using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients
{
    public class OutgoingMessage
    {
        
        public int MsgType { get; set; } //Equal zero 
        
        public string DestinationURL { get; set; } // In case the msg goes to one of our client's systems (we need to be given the endpoint)
        
        public string Content { get; set; }
    }
}
