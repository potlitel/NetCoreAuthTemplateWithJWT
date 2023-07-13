namespace NetCoreAuthTemplateWithJWT.Helpers;

using Microsoft.EntityFrameworkCore;
using NetCoreAuthTemplateWithJWT.Entities;

public class DataContext : DbContext
{
    public DbSet<User> Users { get; set; }

    private readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration) => Configuration = configuration;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // in memory database used for simplicity, change to a real db for production applications
        options.UseInMemoryDatabase("TestDb");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // modelBuilder.Entity<Size>().HasData(
        //         new Size { ID = 1, Name = "Subcompact" },
        //         new Size { ID = 2, Name = "Compact" },
        //         new Size { ID = 3, Name = "Mid Size" },
        //         new Size { ID = 5, Name = "Full Size" }
        //     );

        // modelBuilder.Entity<BodyType>().HasData(
        //     new BodyType { ID = 1, Name = "Coupe" },
        //     new BodyType { ID = 2, Name = "Sedan" },
        //     new BodyType { ID = 3, Name = "Hatchback" },
        //     new BodyType { ID = 4, Name = "Wagon" },
        //     new BodyType { ID = 5, Name = "Convertible" },
        //     new BodyType { ID = 6, Name = "SUV" },
        //     new BodyType { ID = 7, Name = "Truck" },
        //     new BodyType { ID = 8, Name = "Mini Van" },
        //     new BodyType { ID = 9, Name = "Roadster" }
        // );
    }
}