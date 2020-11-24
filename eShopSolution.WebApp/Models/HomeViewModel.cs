using eShopSolution.ViewModel.Catalog.Products;
using eShopSolution.ViewModel.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Models
{
    public class HomeViewModel
    {
        public List<SlideVM> Slides { get; set; }

        public List<ProductVM> FeaturedProducts { get; set; } 
    }
}
