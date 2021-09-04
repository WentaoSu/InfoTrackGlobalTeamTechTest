using BusinessLogic;
using DataAccessor;
using InfoTrackGlobalTeamTechTest;
using InfoTrackGlobalTeamTechTest.Middleware;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Tests.Environments
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration) : base(configuration)
        {
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc().AddApplicationPart(typeof(Startup).Assembly);
            services.AddMediatR(typeof(MediatREntryPoint).Assembly);
            services.AddScoped<IBookingDataAccessor, BookingDataAccessor>();
            services.AddDbContext<BookingContext>(options =>
            {
                options.UseInMemoryDatabase("Booking");
            });
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // add service mocks here if required.
        }

        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<ErrorHandlingMiddleWare>();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
