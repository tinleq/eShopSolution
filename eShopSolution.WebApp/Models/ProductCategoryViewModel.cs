using eShopSolution.ViewModel.Catalog.Categories;
using eShopSolution.ViewModel.Catalog.Products;
using eShopSolution.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVM Category { get; set; }

        public PagedResult<ProductVM> Products {get; set;}
    }
}
