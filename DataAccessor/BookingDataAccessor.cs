using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessor
{
    public class BookingDataAccessor : IBookingDataAccessor
    {
        private readonly BookingContext _context;
        private readonly IMapper _mapper;

        public BookingDataAccessor(BookingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BusinessLogicDataModel.Booking> CreateBookingAsync(BusinessLogicDataModel.Booking booking)
        {
            var bookingEntity = _mapper.Map<EntityModel.Booking>(booking);
            _context.Bookings.Add(bookingEntity);
            await _context.SaveChangesAsync();
            return _mapper.Map<BusinessLogicDataModel.Booking>(bookingEntity);
        }

        public async Task<BusinessLogicDataModel.Booking> GetBookingAsync(Guid bookingId)
        {
            var booking = await _context.Bookings.FirstOrDefaultAsync(d => d.Id == bookingId);

            if(booking == null)
                return null;

            return _mapper.Map <BusinessLogicDataModel.Booking> (booking);
        }

        public async Task UpdateBookingAsync(BusinessLogicDataModel.Booking booking)
        {
            var existingBooking = _context.Bookings.FirstOrDefaultAsync(d => d.Id == booking.Id);

            await _mapper.Map(booking, existingBooking);

            await _context.SaveChangesAsync();
        }

        public async Task<List<BusinessLogicDataModel.Booking>> GetOverlappedBookings(BusinessLogicDataModel.Booking booking)
        {
            var overlappedByFrom = await _context.Bookings.Where(b => booking.From >= b.From && booking.From <= b.To).ToListAsync();
            var overlappedByTo = await _context.Bookings.Where(b => booking.To >= b.From && booking.To <= b.To).ToListAsync();
            // union removes duplicates
            var overlappedBookings = overlappedByFrom.Union(overlappedByTo).ToList();
            return _mapper.Map<List<BusinessLogicDataModel.Booking>>(overlappedBookings);
        }
    }
}
