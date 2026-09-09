using System;
using CompanyService.Application.DTOs;
using Convey.CQRS.Queries;

namespace CompanyService.Application.Queries
{
    public class GetOrder : IQuery<OrderDto>
    {
        public Guid Id { get; set; }
    }
}
