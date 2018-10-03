using AutoMapper;
using BeautyCosmetic.Model.Models;
using BeautyCosmetic.Web.Models;

namespace BeautyCosmetic.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
           
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();

            Mapper.CreateMap<ProductCategory, ProductCategoryViewModel>();
            Mapper.CreateMap<Product, ProductViewModel>();
            Mapper.CreateMap<ProductTag, ProductTagViewModel>();
        }
    }
}