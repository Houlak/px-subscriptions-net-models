using Goova.Subscriptions.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goova.Subscriptions.Models.Requests.Plexo
{
    public class CancelTransactionRequest
    {
        public Subscriptor Subscriptor { get; set; }
        public Client Client { get; set; }
        public Subscription Subscription { get; set; }

        public CancelTransactionRequest(Subscriptor subscriptor, Client client, Subscription subscription)
        {
            Subscriptor = subscriptor;
            Client = client;
            Subscription = subscription;
        }
    }
}
