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
        private object _syncObj = new object();
        private string failedBookingCount = "FailedBookingCount";

        public BookingTests(ScenarioContext scenarioContext, TestHttpClient httpClient)
        {
            _scenarioContext = scenarioContext;
            _httpClient = httpClient;
        }

        [Given(@"There're below bookings:")]
        public async Task GivenThereReBelowBookings(Table table)
        {
            await CreateBookings(table, "ExistingBookings", true);
        }

        private async Task CreateBookings(Table table, string bookingKeyInContext, bool ensureBookingIsMade)
        {
            var bookingRequests = table.CreateSet<BookingInput>().ToList();
            foreach (var request in bookingRequests)
            {
                await CreateOneBooking(bookingKeyInContext, ensureBookingIsMade, request);
            }
        }

        private async Task CreateOneBooking(string bookingKeyInContext, bool ensureBookingIsMade, BookingInput request)
        {
            await _httpClient.PostAsync($"Settlement/create-booking", request);
            var response = _httpClient.ReadResponse<BookingResponse>();
            if (ensureBookingIsMade)
            {
                Assert.True(response.BookingId != Guid.Empty, "bookingId is null!");
            }

            lock (_syncObj)
            {
                if (response.BookingId != Guid.Empty)
                {
                    if (!_scenarioContext.ContainsKey(bookingKeyInContext))
                    {
                        _scenarioContext.Set(new List<BookingResponse> { response }, bookingKeyInContext);
                    }
                    else
                    {
                        var bookings = _scenarioContext.Get<List<BookingResponse>>(bookingKeyInContext);
                        bookings.Add(response);
                        _scenarioContext[bookingKeyInContext] = bookings;
                    }
                }
                else
                {
                    if (!_scenarioContext.ContainsKey(failedBookingCount))
                    {
                        _scenarioContext.Set(1, failedBookingCount);
                    }
                    else
                    {
                        int currentFails = _scenarioContext.Get<int>(failedBookingCount);
                        _scenarioContext[failedBookingCount] = currentFails + 1;
                    }
                }
            }
        }

        [When(@"A new booking is made with below details:")]
        public async Task WhenANewBookingIsMadeWithBelowDetails(Table table)
        {
            await CreateBookings(table, "NewBookings", false);
        }

        [Then(@"the successful new booking count is: (.*)")]
        public void ThenTheSuccessfulNewBookingCountIs(int count)
        {
            if (_scenarioContext.ContainsKey("NewBookings"))
            {
                var bookings = _scenarioContext["NewBookings"] as List<BookingResponse>;
                var nonEmptyBookingCount = bookings.Where(b => b.BookingId != Guid.Empty).Count();
                Assert.Equal(count, nonEmptyBookingCount);
            }
            else
                Assert.Equal(count, 0);
        }

        [Then(@"the failed booking count is: (.*)")]
        public void ThenTheFailedBookingCountIs(int expectedFailedBookingCount)
        {
            int currentFails = _scenarioContext.Get<int>(failedBookingCount);
            Assert.Equal(expectedFailedBookingCount, currentFails);
        }


        [When(@"the below concurrent booking is made:")]
        public async Task WhenTheBelowConcurrentBookingIsMade(Table table)
        {
            var tasks = new List<Task>();
            var bookingRequests = table.CreateSet<BookingInput>().ToList();
            foreach (var request in bookingRequests)
            {
                tasks.Add(Task.Run(async () =>
                {
                    await CreateOneBooking("NewBookings", false, request);
                }));
            }
            await Task.WhenAll(tasks);
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
