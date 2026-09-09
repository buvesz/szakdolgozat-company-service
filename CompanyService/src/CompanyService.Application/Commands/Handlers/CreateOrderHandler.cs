using Convey.CQRS.Commands;
using CompanyService.Core.Repositories;
using System.Threading.Tasks;
using CompanyService.Core.Aggregates;
using CompanyService.Core.Types;
using CompanyService.Application.Exceptions;
using Microsoft.Extensions.Logging;
using System.Threading;

namespace CompanyService.Application.Commands.Handlers
{
    public class CreateOrderHandler : ICommandHandler<CreateOrder>
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly ILogger<CreateOrderHandler> _logger;

        public CreateOrderHandler(IOrdersRepository ordersRepository, ILogger<CreateOrderHandler> logger)
        {
            _ordersRepository = ordersRepository;
            _logger = logger;
        }

        public async Task HandleAsync(CreateOrder command)
        {
            var order = await _ordersRepository.GetAsync(command.Id);

            if(order is not null)
            {
                throw new OrderAlreadyExistsException(command.Id);
            }

            order = new Order(command.Id, command.BuyerId, command.ShippingAddress.AsValueObject(), command.Items.AsEntities(), OrderStatus.Pending);

            await _ordersRepository.AddAsync(order);

            _logger.LogInformation($"Order with ID: {order.Id} has been created.");
        }
    }
}
