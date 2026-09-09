using System;

namespace CompanyService.Core.Exceptions
{
    public abstract class DomainException : Exception
    {
        protected DomainException(string message)
            : base(message) { }
    }
}
