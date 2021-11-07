using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrationLookupApp
{
    public class VehicleRegistrationContext : DbContext
    {

        public VehicleRegistrationContext(DbContextOptions<VehicleRegistrationContext> options) : base(options)
        {

        }

        public DbSet<VehicleDetails> VehicleDetails { get; set; }

    }
}
