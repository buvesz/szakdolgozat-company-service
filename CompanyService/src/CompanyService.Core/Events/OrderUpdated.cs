using CompanyService.Core.Aggregates;
using CompanyService.Core.BuildingBlocks;

namespace CompanyService.Core.Events
{
    public class OrderUpdated : IDomainEvent
    {
        public Order Order { get; }

        public OrderUpdated(Order order)
            => Order = order;
    }
}
