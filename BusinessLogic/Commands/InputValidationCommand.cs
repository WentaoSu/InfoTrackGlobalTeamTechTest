using BusinessLogicDataModel;
using MediatR;

namespace BusinessLogic.Commands
{
    public class InputValidationCommand : IRequest<Booking>
    {
        public BookingInput BookingRequest { get; set; }
    }
}
