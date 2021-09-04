using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessor
{
    public interface IBookingDataAccessor
    {
        Task<BusinessLogicDataModel.Booking> CreateBookingAsync(BusinessLogicDataModel.Booking booking);
        Task<BusinessLogicDataModel.Booking> GetBookingAsync(Guid bookingId);
        Task UpdateBookingAsync(BusinessLogicDataModel.Booking booking);
        Task<List<BusinessLogicDataModel.Booking>> GetOverlappedBookings(BusinessLogicDataModel.Booking booking);
    }
}
