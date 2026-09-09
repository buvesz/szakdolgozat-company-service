using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CompanyService.Application.Commands.WriteModels;
using CompanyService.Core;
using Convey.CQRS.Commands;

namespace CompanyService.Application.Commands
{
    public record CreateOrder([Required] Guid BuyerId, [Required] AddressWriteModel ShippingAddress, [Required] IEnumerable<OrderItemWriteModel> Items) : ICommand
    {
        public Guid Id { get; init; } = new OrderId(Guid.NewGuid());
    }
}
