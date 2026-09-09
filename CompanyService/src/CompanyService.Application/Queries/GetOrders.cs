using System.Collections.Generic;
using CompanyService.Application.DTOs;
using Convey.CQRS.Queries;

namespace CompanyService.Application.Queries
{
    public class GetOrders : IQuery<IEnumerable<OrderDto>> { }
}
