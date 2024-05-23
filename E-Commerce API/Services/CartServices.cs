using System.Linq;
using System.Threading.Tasks;
using E_Commerce_API.DTOs;
using E_Commerce_API.Models;
using E_Commerce_API.Repositories;

namespace E_Commerce_API.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<CartDto> GetCartByUserIdAsync(string userId)
        {
            var cart = await _cartRepository.GetCartByUserIdAsync(userId);
            if (cart == null)
            {
                return null;
            }

            return new CartDto
            {
                Id = cart.Id,
                UserId = cart.UserId,
                CartItems = cart.CartItems.Select(ci => new CartItemDto
                {
                    Id = ci.Id,
                    ProductId = ci.ProductId,
                    ProductName = ci.Product.Name,
                    Quantity = ci.Quantity
                }).ToList()
            };
        }

        public async Task<CartDto> CreateCartAsync(CreateCartDto createCartDto)
        {
            var cart = new Cart
            {
                UserId = createCartDto.UserId,
                CartItems = createCartDto.CartItems.Select(ci => new CartItem
                {
                    ProductId = ci.ProductId,
                    Quantity = ci.Quantity
                }).ToList()
            };

            cart = await _cartRepository.CreateCartAsync(cart);

            return new CartDto
            {
                Id = cart.Id,
                UserId = cart.UserId,
                CartItems = cart.CartItems.Select(ci => new CartItemDto
                {
                    Id = ci.Id,
                    ProductId = ci.ProductId,
                    ProductName = ci.Product.Name,
                    Quantity = ci.Quantity
                }).ToList()
            };
        }

        public async Task UpdateCartAsync(UpdateCartDto updateCartDto)
        {
            var cart = new Cart
            {
                Id = updateCartDto.Id,
                UserId = updateCartDto.UserId,
                CartItems = updateCartDto.CartItems.Select(ci => new CartItem
                {
                    Id = ci.Id,
                    ProductId = ci.ProductId,
                    Quantity = ci.Quantity
                }).ToList()
            };

            await _cartRepository.UpdateCartAsync(cart);
        }

        public async Task<bool> DeleteCartAsync(int id)
        {
            await _cartRepository.DeleteCartAsync(id);
            return true;
        }
    }
}
