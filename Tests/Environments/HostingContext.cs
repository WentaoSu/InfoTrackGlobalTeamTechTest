using BoDi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using TechTalk.SpecFlow;

namespace Tests.Environments
{
    [Binding]
    public static class HostingContext
    {
        internal static TestServer Server { get; private set; }
        [BeforeTestRun]
        public static void Setup(IObjectContainer objectContainer)
        {
            var builder = new WebHostBuilder().UseStartup<TestStartup>();
            Server = new TestServer(builder);
        }

        [AfterTestRun]
        public static void Teardown()
        {
            if (Server != null)
            {
                Server.Dispose();
                Server = null;
            }
        }
    }
}
