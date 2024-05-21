using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public class AppDbContext(AppDbContext context) : DbContext
{
    private readonly AppDbContext _context = context;

    public DbSet<FeatureEntity> Features { get; set; }
    public DbSet<FeatureItemEntity> FeaturesItems { get; set; }
}