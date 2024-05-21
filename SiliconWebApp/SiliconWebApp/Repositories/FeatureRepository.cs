using Microsoft.EntityFrameworkCore;
using SiliconWebApp.Data;
using SiliconWebApp.Entities;
using SiliconWebApp.Factories;
using SiliconWebApp.Models;

namespace SiliconWebApp.Repositories;

public class FeatureRepository(ApplicationDbContext context) : BaseRepository<FeatureEntity>(context)
{
    private readonly ApplicationDbContext _context = context;

    public override async Task<ResponseResult> GetAllAsync()
    {
        try
        {
            IEnumerable<FeatureEntity> result = await _context.Features
                .Include(i => i.FeatureItems)
                .ToListAsync();

            return ResponseFactory.Ok(result);
        }

        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }
}