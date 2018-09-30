using BeautyCosmetic.Data.Infrastructure;
using BeautyCosmetic.Model.Models;

namespace BeautyCosmetic.Data.Repositories
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}