using System;
using CompanyService.Core.BuildingBlocks;

namespace CompanyService.Core
{
    public sealed class OrderItemId : TypedIdValueBase
    {
        public OrderItemId(Guid value)
            : base(value) { }

        public static implicit operator OrderItemId(Guid orderItemId)
            => new OrderItemId(orderItemId);
    }
}
