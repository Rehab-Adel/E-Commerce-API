using System.Threading.Tasks;
using E_Commerce_API.DTOs;

namespace E_Commerce_API.Services
{
    public interface ICartService
    {
        Task<CartDto> GetCartByUserIdAsync(string userId);
        Task<CartDto> CreateCartAsync(CreateCartDto createCartDto);
        Task UpdateCartAsync(UpdateCartDto updateCartDto);
        Task<bool> DeleteCartAsync(int id);
    }
}
