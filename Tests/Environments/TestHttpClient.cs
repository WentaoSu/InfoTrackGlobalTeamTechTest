using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Tests.Environments
{
    public class TestHttpClient
    {
        private ScenarioContext _context;

        public TestHttpClient(ScenarioContext context)
        {
            _context = context;
        }

        public HttpResponseMessage Response
        {
            get
            {
                var response = _context.Get<HttpResponseMessage>("HttpResponseMessage");
                return response;
            }

            private set
            {
                if (_context.ContainsKey("HttpResponseMessage"))
                {
                    _context.Get<HttpResponseMessage>("HttpResponseMessage")?.Dispose();
                }

                _context["HttpResponseMessage"] = value;
                _context["ResponseContent"] = null;
            }
        }

        public async Task GetAsync(string request)
        {
            Response = await HostingContext.Server.CreateRequest("api/" + request).GetAsync();
        }

        public async Task PostAsync<T>(string request, T payload)
        {
            Response = await HostingContext.Server.CreateRequest("api/" + request)
            .And(message => message.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json"))
            .SendAsync("POST");   
        }

        public async Task PutAsync<T>(string request, T payload)
        {
            Response = await HostingContext.Server.CreateRequest("api/" + request)
                .And(message => message.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json"))
                .SendAsync("PUT");
        }

        public T ReadResponse<T>()
            where T : class
        {
            if (_context["ResponseContent"] == null)
            {
                _context["ResponseContent"] = Response.Content.ReadAsStringAsync().Result;
            }

            return JsonConvert.DeserializeObject<T>(_context["ResponseContent"].ToString(), new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
        }

        public void EnsureSuccess()
        {
            if ((int)Response.StatusCode >= 400)
            {
                throw new WebException($"Web request failed. {(int)Response.StatusCode} {Response.ReasonPhrase}");
            }
        }
    }
}
