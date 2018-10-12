using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeautyCosmetic.Web.Models
{
    public class HomeViewModel
    {
        public IEnumerable<SlideViewModel> Slides { set; get; }
        public IEnumerable<ProductViewModel> LastestProducts { set; get; }
        public IEnumerable<ProductViewModel> TopSaleProducts { set; get; }

        public IEnumerable<ProductCategoryViewModel> HeadProductCategory { set; get; }
    }
}