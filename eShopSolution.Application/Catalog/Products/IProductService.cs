﻿using eShopSolution.ViewModel.Catalog.ProductImages;
using eShopSolution.ViewModel.Catalog.Products;
using eShopSolution.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);

        Task<int> Delete(int productId);

        Task<ProductVM> GetById(int productId, string languageId);

        Task<PagedResult<ProductVM>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);

        Task<int> RemoveImage(int imageId);

        Task<ProductImageViewModel> GetImageById(int ImageId);

        Task<List<ProductImageViewModel>> GetListImages(int productId);

        Task<PagedResult<ProductVM>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
    }
}
