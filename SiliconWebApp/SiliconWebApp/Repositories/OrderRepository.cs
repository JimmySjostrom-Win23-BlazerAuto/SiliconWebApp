using SiliconWebApp.Data;
using SiliconWebApp.Entities;
using SiliconWebApp.Repositories;

namespace SiliconWebApp.Repositories;

public class OrderRepository : BaseRepository<OrderEntity>
{
    public OrderRepository(ApplicationDbContext context) : base(context)
    {
    }
}
