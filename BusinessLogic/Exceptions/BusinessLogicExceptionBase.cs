using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Exceptions
{
    public class BusinessLogicExceptionBase : Exception
    {
        public BusinessLogicExceptionBase(string message) : base(message)
        {
        }

        /// <summary>
        /// Use this constructor to preserve the original stack trace
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerexception"></param>
        public BusinessLogicExceptionBase(string message, Exception innerexception) : base(message, innerexception)
        {
        }
    }
}
