using BusinessLogicDataModel;
using MediatR;
using System;

namespace BusinessLogic.Queries
{
    public class GetOneBookingQuery : IRequest<Booking>
    {
        public Guid BookingId { get; set; }
    }
}
