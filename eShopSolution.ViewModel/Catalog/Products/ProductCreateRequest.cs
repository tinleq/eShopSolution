﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModel.Catalog.Products
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int OriginalPrice { get; set; }

        public int Stock { get; set; }

        public string Description { get; set; }

        public string SeoDescription { get; set; }

        public string Details { get; set; }

        public string SeoTitle { get; set; }

        public string SeoAlias { get; set; }

        public string LanguageId { get; set; }

        public IFormFile ThumbnailImage { get; set; }
    }
}
