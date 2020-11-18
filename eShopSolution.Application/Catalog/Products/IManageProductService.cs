using eShopSolution.ViewModel.Catalog.Products;
using eShopSolution.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);

        Task<int> Delete(int productId);

        Task<PageResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImages(int productId, List<IFormFile> files);

        Task<int> UpdateImages(int imageId, string caption, bool isDefault);

        Task<int> RemoveImages(int imageId);

        Task<List<ProductImageViewModel>> GetListImages(int productId);
    }
}
