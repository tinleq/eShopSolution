using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolution.ViewModel.Catalog.Products
{
    public class ProductCreateRequest
    {
        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        [Display(Name ="Tên sản phẩm")]
        public string Name { get; set; }

        [Display(Name = "Giá bán")]
        public decimal Price { get; set; }

        [Display(Name = "Giá nhập")]
        public int OriginalPrice { get; set; }

        [Display(Name = "Số lượng")]
        public int Stock { get; set; }

        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        [Display(Name = "Mô tả SEO")]
        public string SeoDescription { get; set; }

        [Display(Name = "Chi tiết")]
        public string Details { get; set; }

        [Display(Name = "Tiêu đề SEO")]
        public string SeoTitle { get; set; }

        [Display(Name = "SEO Alias")]
        public string SeoAlias { get; set; }

        [Display(Name = "Mã ngôn ngữ")]
        public string LanguageId { get; set; }


        public bool? IsFeatured { get; set; }

        [Display(Name = "Hình thu nhỏ")]
        public IFormFile ThumbnailImage { get; set; }
    }
}
