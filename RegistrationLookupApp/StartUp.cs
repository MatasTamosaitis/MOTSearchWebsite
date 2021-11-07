using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: FunctionsStartup(typeof(RegistrationLookupApp.StartUp))]

namespace RegistrationLookupApp
{
    public class StartUp : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            string connectionString = Environment.GetEnvironmentVariable("DefaultConnection");
            builder.Services.AddDbContext<VehicleRegistrationContext>(
              options => SqlServerDbContextOptionsExtensions.UseSqlServer(options, connectionString));
        }
    }
}
