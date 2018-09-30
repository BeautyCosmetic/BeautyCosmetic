using System;

namespace BeautyCosmetic.Data.Infrastructure
{
    // Là giao tiếp khởi tạo các đối tượng Entity, ko khởi tạo trực tiếp mà thông qua Factory
    public interface IDbFactory : IDisposable
    {
        BeautyCosmeticDbContext Init();
    }
}