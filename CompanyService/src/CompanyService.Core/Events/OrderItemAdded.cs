using CompanyService.Core.BuildingBlocks;
using CompanyService.Core.Entities;

namespace CompanyService.Core.Events
{
    public class OrderItemAdded : IDomainEvent
    {
        public OrderItem OrderItem { get; }

        public OrderItemAdded(OrderItem orderItem)
            => OrderItem = orderItem;
    }
}
