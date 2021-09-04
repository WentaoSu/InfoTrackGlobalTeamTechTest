using BusinessLogicDataModel;
using InfoTrackGlobalTeamTechTest.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Tests.Environments;
using Xunit;

namespace Tests.Steps
{
    [Binding]
    public sealed class BookingTests
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private readonly TestHttpClient _httpClient;

        public BookingTests(ScenarioContext scenarioContext, TestHttpClient httpClient)
        {
            _scenarioContext = scenarioContext;
            _httpClient = httpClient;
        }

        [Given(@"There're below bookings:")]
        public async Task GivenThereReBelowBookings(Table table)
        {
            await CreateBooking(table, "ExistingBookings");
        }

        private async Task CreateBooking(Table table, string bookingKeyInContext)
        {
            var bookingRequests = table.CreateSet<BookingInput>().ToList();
            foreach (var request in bookingRequests)
            {
                await _httpClient.PostAsync($"Settlement/create-booking", request);
                var response = _httpClient.ReadResponse<BookingResponse>();
                //Assert.NotNull(response);
                //Assert.True(response.BookingId != Guid.Empty);

                if (!_scenarioContext.ContainsKey(bookingKeyInContext))
                {
                    _scenarioContext.Set( new List<BookingResponse> { response }, bookingKeyInContext);
                }
                else
                {
                    var bookings = _scenarioContext.Get<List<BookingResponse>>(bookingKeyInContext);
                    bookings.Add(response);
                    _scenarioContext[bookingKeyInContext] = bookings;
                }
            }
        }

        [When(@"A new booking is made with below details:")]
        public async Task WhenANewBookingIsMadeWithBelowDetails(Table table)
        {
            await CreateBooking(table, "NewBookings");
        }

        //[Then(@"the booking is created with http status code: (.*)")]
        //public void ThenTheBookingIsCreatedWithHttpStatusCode(int statusCode)
        //{
        //    var responseMsg = _scenarioContext.Get<HttpResponseMessage>("HttpResponseMessage");
        //    Assert.Equal(statusCode, (int)responseMsg.StatusCode);
        //}

        [Then(@"the successful new booking count is: (.*)")]
        public void ThenTheSuccessfulNewBookingCountIs(int count)
        {
            var responseMsg = _scenarioContext.Get<HttpResponseMessage>("HttpResponseMessage");
            if (_scenarioContext.ContainsKey("NewBookings"))
            {
                var bookings = _scenarioContext["NewBookings"] as List<BookingResponse>;
                var nonEmptyBookingCount = bookings.Where(b => b.BookingId != Guid.Empty).Count();
                Assert.Equal(count, nonEmptyBookingCount);
            }
            else
                Assert.Equal(count, 0);
        }

        [Then(@"the booking api returns http status code: (.*)")]
        public void ThenTheBookingApiReturnsHttpStatusCode(int statusCode)
        {
            var responseMsg = _scenarioContext.Get<HttpResponseMessage>("HttpResponseMessage");
            Assert.Equal(statusCode, (int)responseMsg.StatusCode);
        }


        [AfterScenario("BookingTestsTag")]
        public void AfterScenario()
        {
            _scenarioContext.Clear();
        }
    }
}
