using System;
using System.Threading.Tasks;
using CompanyService.Application.Commands;
using CompanyService.Application.Queries;
using CompanyService.Application.Dispatchers;
using Microsoft.AspNetCore.Mvc;

namespace CompanyService.Api.Controllers
{
    public class OrdersController : BaseController
    {
        public OrdersController(IDispatcher dispatcher)
            : base(dispatcher) { }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get([FromRoute] GetOrder query)
            => Select(await Dispatcher.QueryAsync(query));

        [HttpGet]
        public async Task<IActionResult> Get([FromRoute] GetOrders query)
            => Select(await Dispatcher.QueryAsync(query));

        [HttpPost]
        public async Task<IActionResult> Post(CreateOrder command)
        {
            await Dispatcher.SendAsync(command);

            return CreatedAtAction(nameof(Get), new { Id = command.Id }, command.Id);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Put(Guid id, UpdateOrder command)
        {
            await Dispatcher.SendAsync(new UpdateOrder(id, command.BuyerId, command.ShippingAddress, command.Items, command.Status));

            return NoContent();
        }
    }
}
