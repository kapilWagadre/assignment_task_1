using Microsoft.EntityFrameworkCore;

namespace assignment_task_1.Models

{
    public class DataBaseConnect : DbContext
    {
        public DataBaseConnect(DbContextOptions<DataBaseConnect> options) : base(options)
        {
        }
        public DbSet<Sing_in> Singin { get; set; }
        public DbSet<Product> Products { get; set; }
     
        public DbSet<Category> Category { get; set; }
        public DbSet<UPIPayment> UPIPayments { get; set; }
        public DbSet<Customer> Customers { get; set; }

       
    }
   
}
