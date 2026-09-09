using System;
using CompanyService.Application.Exceptions;

namespace CompanyService.Infrastructure.Exceptions.Definition
{
    public interface IExceptionCompositionRoot
    {
        ExceptionResponse Map(Exception exception);
    }
}
