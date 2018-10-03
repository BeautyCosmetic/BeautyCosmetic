using BeautyCosmetic.Data.Infrastructure;
using BeautyCosmetic.Model.Models;

namespace BeautyCosmetic.Data.Repositories
{
    public interface IOrderRepository  : IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}