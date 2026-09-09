using System.Collections.Generic;
using System.Linq;
using CompanyService.Application.Commands.WriteModels;
using CompanyService.Core.Entities;
using CompanyService.Core.ValueObjects;

namespace CompanyService.Application.Commands
{
    public static class Extensions
    {
        public static IEnumerable<OrderItem> AsEntities(this IEnumerable<OrderItemWriteModel> orderItems)
            => orderItems.Select(orderItem => new OrderItem(orderItem.Name, orderItem.Quantity, orderItem.UnitPrice));

        public static Address AsValueObject(this AddressWriteModel address)
            => address is null
                ? null
                : new Address(address.City, address.Street, address.Province, address.Country, address.ZipCode);
    }
}
