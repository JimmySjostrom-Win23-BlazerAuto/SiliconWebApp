using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SiliconWebApp.Entities;

namespace SiliconWebApp.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<UserAddress> UserAddresses { get; set; }
    public DbSet<FeatureEntity> Features { get; set; }
    public DbSet<FeatureItemEntity> FeaturesItems { get; set; }
    public DbSet<OrderEntity> Orders { get; set; }
}