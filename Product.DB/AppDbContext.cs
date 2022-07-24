using Microsoft.EntityFrameworkCore;


namespace Product.DB
{
    public class AppDbContext : DbContext
    {
            public DbSet<Product> Products { get; set; }


            // The following configures EF to create a sql database file in the
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
               optionsBuilder.UseSqlServer(
                @"Server = (localdb)\mssqllocaldb; Database = product; Trusted_Connection = True;"
                );
            }
            /// <summary>
            /// This method is called only once when the first instance of a derived context is created
            /// </summary>
            /// <param name="modelBuilder"></param>
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Seed();
            }


    }
}
