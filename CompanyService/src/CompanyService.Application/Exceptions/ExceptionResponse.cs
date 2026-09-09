using System.Net;

namespace CompanyService.Application.Exceptions
{
    public record ExceptionResponse(object Response, HttpStatusCode StatusCode);
}
