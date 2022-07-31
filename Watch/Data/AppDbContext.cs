using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Watch.Models;

namespace Watch.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser,IdentityRole,string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order>Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUserRole<string>>().HasKey(ub => new { ub.UserId, ub.RoleId });
            builder.Entity<IdentityUserLogin<string>>().HasKey(ub => ub.UserId);
            builder.Entity<IdentityUserToken<string>>().HasKey(ub => ub.UserId);
            builder.Entity<IdentityUserClaim<string>>();
            builder.Entity<IdentityRoleClaim<string>>();
            builder.Entity<OrderDetail>()
                .HasKey(e => new
                {
                    e.OrderId,
                    e.ProductId
                });
            builder.Entity<ApplicationUser>()
                .HasMany(x => x.Orders)
                .WithOne(y => y.User)
                .HasForeignKey(x => x.CustomerId);
        }

    }
}
