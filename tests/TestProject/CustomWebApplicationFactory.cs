using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppFactoryRepo;

namespace TestProject
{
    public class CustomWebApplicationFactory : WebApplicationFactory<Program>
    {
        protected override IHostBuilder CreateHostBuilder()
        {
            var builder = base.CreateHostBuilder(); // This should NOT be null.

            builder.ConfigureWebHost(webHost =>
            {
                webHost.UseStartup<Startup>();
                webHost.UseEnvironment("Staging");
            });

            return builder;
        }
    }
}
