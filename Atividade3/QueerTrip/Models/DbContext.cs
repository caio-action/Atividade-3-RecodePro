using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QueerTrip.Models
{
    public class userDbContext : DbContext 
    {
        public userDbContext(DbContextOptions<userDbContext> options):base(options)
        {

        }

        public DbSet<Context> users { get; set; }

    }
}

