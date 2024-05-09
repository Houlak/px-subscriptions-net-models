
using Goova.Subscriptions.Models.Dtos.PaymentFacilitator;
using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Entities
{
    public class PaymentFacilitatorCommerceId : BaseEntity
    {
        public int? Id { get; set; }
        public int Value { get; set; }

        public static ICollection<PaymentFacilitatorCommerceId> FromListToCollectionPFCommerceId(IEnumerable<PaymentFacilitatorCommerceIdDto> commerceIds)
        {
            List<PaymentFacilitatorCommerceId> ret = new List<PaymentFacilitatorCommerceId>();

            foreach (var commId in commerceIds)
            {
                ret.Add(new PaymentFacilitatorCommerceId { Value = commId.Value });
            }

            return ret;
        }

        public static ICollection<PaymentFacilitatorCommerceIdDto> FromCommerceIdsToInts(IEnumerable<PaymentFacilitatorCommerceId> commerceIds)
        {
            List<PaymentFacilitatorCommerceIdDto> ret = new List<PaymentFacilitatorCommerceIdDto>();

            foreach (PaymentFacilitatorCommerceId commId in commerceIds)
            {
                ret.Add(new PaymentFacilitatorCommerceIdDto() { Id = (int)commId.Id, Value = commId.Value });
            }

            return ret;
        }
    }
}
