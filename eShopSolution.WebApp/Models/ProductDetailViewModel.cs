using eShopSolution.ViewModel.Catalog.Categories;
using eShopSolution.ViewModel.Catalog.ProductImages;
using eShopSolution.ViewModel.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryVM Category { get; set; }

        public ProductVM Product { get; set; }

        public List<ProductVM> RelatedProducts { get; set; }

        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}
