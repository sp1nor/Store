using Store.Domain.Common.Models;
using System;
using System.Collections.Generic;

namespace Ordering.API.Entities
{
    public class SalesId : ValueObject
    {
        public Guid Value { get; }

        public SalesId(Guid value)
        {
            Value = value;
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
