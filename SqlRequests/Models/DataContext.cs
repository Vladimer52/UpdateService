using Microsoft.EntityFrameworkCore;

namespace SqlRequests.Models
{
    public class DataContext: DbContext
    {
        public DbSet<Firm> Firms { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Contracts> Contracts { get; set; }
        public DbSet<ContractProperty> ContractProperties { get; set; }
        public DbSet<People> Peoples { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {
            Database.EnsureCreated(); //if BD don`t exist, it`s create her
        }
    }
}
