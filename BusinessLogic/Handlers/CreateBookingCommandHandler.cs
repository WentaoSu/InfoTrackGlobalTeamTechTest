using AutoMapper;
using BusinessLogic.Commands;
using BusinessLogic.Exceptions;
using BusinessLogicDataModel;
using DataAccessor;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogic.Handlers
{
    public class CreateBookingCommandHandler : IRequestHandler<CreateBookingCommand, Booking>
    {
        private readonly IBookingDataAccessor _dataAccessor;
        private readonly IMapper _mapper;
        private static SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        public CreateBookingCommandHandler(IBookingDataAccessor dataAccessor, IMapper mapper)
        {
            _dataAccessor = dataAccessor;
            _mapper = mapper;
        }

        public async Task<Booking> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            // syncronise calls for booking creation
            await _semaphore.WaitAsync();
            try
            {
                var bookingRequestModel = _mapper.Map<Booking>(request.BookingInput);
                var overlappedBookings = await _dataAccessor.GetOverlappedBookings(bookingRequestModel);
                if (overlappedBookings.Count >= 4)
                    throw new TimeslotBookedOutException(bookingRequestModel.From, bookingRequestModel.To);

                return await _dataAccessor.CreateBookingAsync(request.BookingInput);
            }
            finally
            {
                _semaphore.Release();
            }
        }
    }
}
