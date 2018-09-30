using BeautyCosmetic.Data.Infrastructure;
using BeautyCosmetic.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace BeautyCosmetic.Data.Repositories
{
    public interface IProductCategoryRepository  // định nghĩa các phương thức cần phải thêm
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}