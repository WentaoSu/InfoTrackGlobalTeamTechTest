using Newtonsoft.Json;
using System;

namespace InfoTrackGlobalTeamTechTest.Responses
{
    /// <summary>
    /// Contains a Guid BookingId, returned after Booking is successfully created
    /// </summary>
    public class BookingResponse
    {
        /// <summary>
        /// Guid BookingId
        /// </summary>
        [JsonProperty("bookingId")]
        public Guid BookingId { get; set; }
    }
}
