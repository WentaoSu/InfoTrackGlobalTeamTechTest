using AutoMapper;
using BusinessLogic.Commands;
using BusinessLogic.Exceptions;
using BusinessLogicDataModel;
using DataAccessor;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogic.Handlers
{
    public class InputValidationCommandHandler : IRequestHandler<InputValidationCommand, Booking>
    {
        private readonly IBookingDataAccessor _accessor;
        private readonly IMapper _mapper;

        public InputValidationCommandHandler(IBookingDataAccessor accessor, IMapper mapper)
        {
            _accessor = accessor;
            _mapper = mapper;
        }
        async Task<Booking> IRequestHandler<InputValidationCommand, Booking>.Handle(InputValidationCommand request, CancellationToken cancellationToken)
        {
            return await ValidateInput(request.BookingRequest);
        }

        public async Task<Booking> ValidateInput(BookingInput bookingInput)
        {
            EnsureInputStringAreValid(bookingInput);
            var bookingRequestModel = _mapper.Map<Booking>(bookingInput);
            EnsureBookingWithinOfficeHour(bookingRequestModel);
            await EnsureBookingIsAvailable(bookingRequestModel);
            return bookingRequestModel;
        }

        public void EnsureInputStringAreValid(BookingInput bookingInput)
        {
            var isDateTimeValid = DateTime.TryParse(bookingInput.BookingTime, out DateTime fromTime);
            if (!isDateTimeValid)
                throw new InvalidTimeFormatException(bookingInput.BookingTime);

            if (string.IsNullOrWhiteSpace(bookingInput.Name))
                throw new CustomerNameIsEmptyException();
        }

        public void EnsureBookingWithinOfficeHour(Booking bookingInput)
        {
            TimeSpan fromSpan = bookingInput.From.TimeOfDay;
            TimeSpan toSpan = bookingInput.To.TimeOfDay;

            if (fromSpan.Hours < Constants.OfficeHourStart || (toSpan.Hours >= Constants.OfficeHourEnd && toSpan.Minutes > 0))
                throw new OutSideBusinessHourException(bookingInput.From, bookingInput.To);
        }

        public async Task EnsureBookingIsAvailable(Booking bookingInput)
        {
            var overlappedBookings = await _accessor.GetOverlappedBookings(bookingInput);
            if (overlappedBookings.Count >= 4)
                throw new TimeslotBookedOutException(bookingInput.From, bookingInput.To);
        }
    }
}
