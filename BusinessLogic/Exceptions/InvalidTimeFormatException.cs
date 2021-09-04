using System;

namespace BusinessLogic.Exceptions
{
    public class InvalidTimeFormatException : BusinessLogicExceptionBase
    {
        public InvalidTimeFormatException(string timeInput) : base($"Time input is invalid, offending value is: {timeInput}")
        {
        }

        public InvalidTimeFormatException(string timeInput, Exception innerexception) : base($"Time input is invalid, offending value is: {timeInput}", innerexception)
        {
        }
    }
}
