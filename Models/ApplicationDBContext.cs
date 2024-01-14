
using Microsoft.EntityFrameworkCore;
using System.Configuration;
    
namespace BRTS.Web.Models
{
    public class ApplicationDBContext : DbContext
    {   
           
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=TEST;Integrated Security=True;Trust Server Certificate=True");
        }

        public DbSet<Account> Account { get; set; }
        public DbSet<BookedRequests> BookedRequests { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Trip> Trips{ get; set; }






    }
} 
 