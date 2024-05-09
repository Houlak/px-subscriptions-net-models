using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Entities
{
    public class Style : ValueObject
    {
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return PrimaryColor;
            yield return SecondaryColor;
        }
    }
}
