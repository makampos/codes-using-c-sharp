using System;

namespace EXCEPTION_DEMO.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {            
        }
    }
}