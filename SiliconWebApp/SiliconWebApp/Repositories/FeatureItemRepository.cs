using SiliconWebApp.Data;
using SiliconWebApp.Entities;

namespace SiliconWebApp.Repositories;

public class FeatureItemRepository(ApplicationDbContext context) : BaseRepository<FeatureItemEntity>(context)
{
    private readonly ApplicationDbContext _context = context;
}
