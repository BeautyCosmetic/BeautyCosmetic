namespace BeautyCosmetic.Data.Infrastructure
{
    // Khởi tạo các đối tượng DbContext
    public class DbFactory : Disposable, IDbFactory
    {
        private BeautyCosmeticDbContext dbContext;

        public BeautyCosmeticDbContext Init()
        {
            // Kt nếu Null thì new một cái
            return dbContext ?? (dbContext = new BeautyCosmeticDbContext());
        }

        protected override void DisposeCore()
        {
            // Khác Null thì Dispose nó
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}