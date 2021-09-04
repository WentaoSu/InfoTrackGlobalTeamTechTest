using BusinessLogic.Queries;
using BusinessLogicDataModel;
using DataAccessor;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogic.Handlers
{
    public class GetOneBookingQueryHandler : IRequestHandler<GetOneBookingQuery, Booking>
    {
        private readonly IBookingDataAccessor _bookingDataAccessor;

        public GetOneBookingQueryHandler(IBookingDataAccessor bookingDataAccessor)
        {
            _bookingDataAccessor = bookingDataAccessor;
        }
        public Task<Booking> Handle(GetOneBookingQuery request, CancellationToken cancellationToken)
        {
            var booking = _bookingDataAccessor.GetBookingAsync(request.BookingId);
            return booking;
        }
    }
}
