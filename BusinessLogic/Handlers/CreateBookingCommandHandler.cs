using BusinessLogic.Commands;
using BusinessLogicDataModel;
using DataAccessor;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogic.Handlers
{
    public class CreateBookingCommandHandler : IRequestHandler<CreateBookingCommand, Booking>
    {
        private readonly IBookingDataAccessor _dataAccessor;

        public CreateBookingCommandHandler(IBookingDataAccessor dataAccessor)
        {
            _dataAccessor = dataAccessor;
        }
        public async Task<Booking> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            return await _dataAccessor.CreateBookingAsync(request.BookingInput);
        }
    }
}
