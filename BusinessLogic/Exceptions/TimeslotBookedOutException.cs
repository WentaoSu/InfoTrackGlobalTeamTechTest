using System;

namespace BusinessLogic.Exceptions
{
    public class TimeslotBookedOutException : BusinessLogicExceptionBase
    {
        public TimeslotBookedOutException(DateTime from, DateTime to) : base($"Current booking time is taken, please try a different time slot. Current booking period is: {from.ToString("HH:mm")} - {to.ToString("HH:mm")}.")
        {
        }

        public TimeslotBookedOutException(DateTime from, DateTime to, Exception innerexception) : base($"Current booking time is taken, please try a different time slot. Current booking period is: {from.ToString("HH:mm")} - {to.ToString("HH:mm")}.", innerexception)
        {
        }
    }
}
