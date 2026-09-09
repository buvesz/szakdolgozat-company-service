using System;
using CompanyService.Core.BuildingBlocks;

namespace CompanyService.Core
{
    public class BuyerId : TypedIdValueBase
    {
        public BuyerId(Guid value)
            : base(value) { }

        public static implicit operator BuyerId(Guid buyerId)
            => new BuyerId(buyerId);
    }
}
