using CallLogTicketing.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CallLogTicketing.Models;
using CallLogTicketing.Enum;

namespace CallLogTicketing.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reseller> Resellers { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<TicketType> TicketTypes { get; set; }

        public DbSet<Assign> AssignTo { get; set; }

        public DbSet<Tickets> Tickets { get; set; }
    }
}