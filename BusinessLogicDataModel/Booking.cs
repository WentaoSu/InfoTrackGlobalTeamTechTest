using System;

namespace BusinessLogicDataModel
{
    public class Booking
    {
        public Guid Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Name { get; set; }
    }
}
