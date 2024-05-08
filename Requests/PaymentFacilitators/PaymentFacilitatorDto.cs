using System;

namespace Goova.Subscriptions.Models.Requests.PaymentFacilitator
{
    public class PaymentFacilitatorDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int PaymentFacilitatorPlexoId { get; set; }
    }
}
