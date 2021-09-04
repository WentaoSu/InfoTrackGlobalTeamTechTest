using Newtonsoft.Json;

namespace BusinessLogicDataModel
{
    /// <summary>
    /// Request payload for creating a booking
    /// </summary>
    public class BookingInput
    {
        /// <summary>
        /// Booking Time is in 24 hour format, and It should be between 9:00 - 17:00
        /// </summary>
        [JsonProperty("bookingTime")]
        public string BookingTime { get; set; }
        /// <summary>
        /// Name of the booking
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
