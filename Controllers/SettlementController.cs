using AutoMapper;
using BusinessLogic.Commands;
using BusinessLogic.Queries;
using BusinessLogicDataModel;
using InfoTrackGlobalTeamTechTest.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace InfoTrackGlobalTeamTechTest.Controllers
{
    /// <summary>
    /// SettlementController
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SettlementController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        /// <summary>
        /// SettlementController constructor
        /// </summary>
        /// <param name="mediator"></param>
        /// <param name="mapper"></param>
        public SettlementController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        /// <summary>
        /// Create booking based on BookingRequest object, if succeeded, the booking id is returned.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("create-booking")]
        public async Task<IActionResult> CreateBooking([FromBody, Required] BookingInput request)
        {
            var validatedBookingInput = await _mediator.Send(new InputValidationCommand { BookingRequest = request });
            var bookingCreated = await _mediator.Send(new CreateBookingCommand { BookingInput = validatedBookingInput });
            var uriStr = $"{Request.Scheme}://{Request.Host}{Request.PathBase}/settlement/{bookingCreated.Id}";
            return Created(new Uri(uriStr), _mapper.Map<BookingResponse>(bookingCreated));
        }

        /// <summary>
        /// Retrieve One booking by booking Id.
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns></returns>
        [HttpGet("retrieve-booking")]
        public async Task<IActionResult> RetrieveBooking([FromQuery, Required] Guid bookingId)
        {
            var booking = await _mediator.Send(new GetOneBookingQuery { BookingId = bookingId });
            return Ok(_mapper.Map<BookingResponse>(booking));
        }

        /// <summary>
        /// Some instructions for this api project
        /// </summary>
        /// <returns></returns>
        [HttpGet("readme")]
        public IActionResult GetReadMeText()
        {
            return Ok("Thanks for the fun test, I have covered pretty much all topics mentioned in the previous interview in this solution. To run unit test, please download SpecFlow extension in your Visual Studio (and you might have to register for the first time use, check the output of the test results, there should be a link to take you to the registration page.).");
        }
    }
}