using System;

namespace BusinessLogic.Exceptions
{
    public class CustomerNameIsEmptyException : BusinessLogicExceptionBase
    {
        public CustomerNameIsEmptyException() : base("Customer name cannot be empty!")
        {
        }

        public CustomerNameIsEmptyException( Exception innerexception) : base("Customer name cannot be empty!", innerexception)
        {
        }
    }
}
