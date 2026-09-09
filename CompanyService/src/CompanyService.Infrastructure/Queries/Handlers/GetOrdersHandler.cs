using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using CompanyService.Application.DTOs;
using CompanyService.Application.Queries;
using CompanyService.Core.Repositories;
using System.Threading;
using Convey.CQRS.Queries;
using CompanyService.Infrastructure.Mappings;

namespace CompanyService.Infrastructure.Queries.Handlers
{
    public class GetOrdersHandler : IQueryHandler<GetOrders, IEnumerable<OrderDto>>
    {
        private readonly IOrdersRepository _repository;

        public GetOrdersHandler(IOrdersRepository repository)
            => _repository = repository;

        public async Task<IEnumerable<OrderDto>> HandleAsync(GetOrders query)
            => (await _repository.BrowseAsync())
                ?.Select(order => order.AsDto());
    }
}
