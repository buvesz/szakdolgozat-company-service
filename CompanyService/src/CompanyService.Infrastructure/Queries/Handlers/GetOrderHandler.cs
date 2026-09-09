using System.Threading;
using System.Threading.Tasks;
using CompanyService.Application.DTOs;
using CompanyService.Application.Queries;
using CompanyService.Core.Repositories;
using CompanyService.Infrastructure.Mappings;
using Convey.CQRS.Queries;

namespace CompanyService.Infrastructure.Queries.Handlers
{
    public class GetOrderHandler : IQueryHandler<GetOrder, OrderDto>
    {
        private readonly IOrdersRepository _repository;

        public GetOrderHandler(IOrdersRepository repository)
            => _repository = repository;

        public async Task<OrderDto> HandleAsync(GetOrder query)
            => (await _repository.GetAsync(query.Id))
                ?.AsDto();
    }
}
