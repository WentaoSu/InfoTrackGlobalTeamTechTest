using System;

namespace BusinessLogic.Exceptions
{
    public class OutSideBusinessHourException : BusinessLogicExceptionBase
    {
        public OutSideBusinessHourException(DateTime from, DateTime to) : base($"InfoTrack's hours of business are 9am-5pm, current booking period is: {from.ToString("HH:mm")} - {to.ToString("HH:mm")}.")
        {
        }

        public OutSideBusinessHourException(DateTime from, DateTime to, Exception innerexception) : base($"InfoTrack's hours of business are 9am-5pm, current booking period is: {from.ToString("HH:mm")} - {to.ToString("HH:mm")}.", innerexception)
        {
        }
    }
}
