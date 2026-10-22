using Microsoft.EntityFrameworkCore;
using rest_api.Models;

namespace rest_api.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData
            (
                           new Product
                            {
                                Id = new Guid("11111111-1111-1111-1111-111111111111"),
                                Name = "Laptop",
                                Price = 85000.00,
                                Count = 10,
                                DateAdded = new DateTime(2026, 12, 22, 0, 0, 0, DateTimeKind.Utc)
                            },
            new Product
            {
                Id = new Guid("11111111-1111-1111-1111-111111111112"),
                Name = "Laptop",
                Price = 85000.00,
                Count = 10,
                DateAdded = new DateTime(2026, 10, 12, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = new Guid("11111111-1111-1111-1111-111111111113"),
                Name = "Laptop",
                Price = 85000.00,
                Count = 10,
                DateAdded = new DateTime(2026, 10, 20, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = new Guid("11111111-1111-1111-1111-411111111111"),
                Name = "Smartphone",
                Price = 45000.00,
                Count = 25,
                DateAdded = new DateTime(2026, 10, 22, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = new Guid("11111111-5111-1111-1111-111111111111"),
                Name = "Keyboard",
                Price = 2500.00,
                Count = 40,
                DateAdded = new DateTime(2026, 10, 12, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = new Guid("61111111-1111-1111-1111-111111111111"),
                Name = "Mouse",
                Price = 1200.00,
                Count = 50,
                DateAdded = new DateTime(2026, 10, 22, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = new Guid("11111111-8111-1111-1111-111111111111"),
                Name = "Monitor",
                Price = 18000.00,
                Count = 15,
                DateAdded = new DateTime(2026, 10, 27, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = new Guid("11111111-1111-1111-1511-111111111111"),
                Name = "Headphones",
                Price = 3500.00,
                Count = 30,
                DateAdded = new DateTime(2026, 10, 22, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = new Guid("11111111-1191-1111-1111-111111111111"),
                Name = "Printer",
                Price = 22000.00,
                Count = 8,
                DateAdded = new DateTime(2026, 10, 12, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = new Guid("11111110-1111-1111-1111-111111111111"),
                Name = "USB Flash Drive",
                Price = 800.00,
                Count = 100,
                DateAdded = new DateTime(2026, 10, 22, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = new Guid("11171111-1111-1111-1111-111111111111"),
                Name = "External Hard Drive",
                Price = 9500.00,
                Count = 20,
                DateAdded = new DateTime(2026, 10, 24, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = new Guid("11111111-1111-1111-1111-111111111119"),
                Name = "Webcam",
                Price = 4000.00,
                Count = 12,
                DateAdded = new DateTime(2026, 10, 22, 0, 0, 0, DateTimeKind.Utc)
            }

            );
        }

        public DbSet<Product> products { get; set; }
    }
}
