using DemoDotNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DemoDotNetCore.Infrastructor.DBConText
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>(x =>
            {
                x.ToTable("Products")
                    .HasKey(p => p.Id);

                x.Property(product => product.Name)
                    .IsRequired(true)
                    .HasMaxLength(250);

                x.Property(product => product.Container)
                    .IsRequired(false)
                    .HasMaxLength(250);

                x.Property(e => e.Description)
                    .IsRequired(false)
                    .HasMaxLength(1000);
            });
        }
    }

    public class TemplateContextDesignFactory : IDesignTimeDbContextFactory<DemoContext>
    {
        public DemoContext CreateDbContext(string[] args)
        {
            string localConn = "Server=localhost;Initial Catalog=DemoNetCore;Integrated Security = true";
            var optionsBuilder = new DbContextOptionsBuilder<DemoContext>()
                .UseSqlServer(localConn)
                .EnableSensitiveDataLogging(true);
            return new DemoContext(optionsBuilder.Options);
        }
    }
}
