using Microsoft.EntityFrameworkCore;

namespace SqlRequests.Models
{
    public class DataContext: DbContext
    {
        public DbSet<Firms> Firms { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Contracts> Contracts { get; set; }
        public DbSet<Peoples> Peoples { get; set; }
        public DbSet<Properties> Properties { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<ContractProperties> ContractProperties { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {
            Database.EnsureCreated(); //if BD don`t exist, to create her
        }
    }
}
