using System.Collections.Generic;
using System.Threading.Tasks;
using E_Commerce_API.DTOs;

namespace E_Commerce_API.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int id);
        Task<ProductDto> CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task<bool> DeleteProductAsync(int id);
    }
}
