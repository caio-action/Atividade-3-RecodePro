
using Microsoft.EntityFrameworkCore;

namespace QueerTrip.Models
{

    public class Context : DbContext
    {


        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<user> user { get; set; }




    }
}