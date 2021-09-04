using BusinessLogicDataModel;
using MediatR;

namespace BusinessLogic.Commands
{
    public class CreateBookingCommand : IRequest<Booking>
    {
        public Booking BookingInput { get; set; }
    }
}
