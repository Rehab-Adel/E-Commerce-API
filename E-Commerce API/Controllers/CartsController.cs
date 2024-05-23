using Microsoft.AspNetCore.Mvc;
using E_Commerce_API.DTOs;
using E_Commerce_API.Services;
using System.Threading.Tasks;

namespace E_Commerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartsController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<CartDto>> GetCartAsync(string userId)
        {
            var cart = await _cartService.GetCartByUserIdAsync(userId);
            if (cart == null)
            {
                return NotFound();
            }

            return Ok(cart);
        }

        [HttpPost]
        public async Task<ActionResult<CartDto>> CreateCartAsync(CreateCartDto createCartDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cart = await _cartService.CreateCartAsync(createCartDto);
            return CreatedAtAction(nameof(GetCartAsync), new { userId = cart.UserId }, cart);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCartAsync(int id, UpdateCartDto updateCartDto)
        {
            if (id != updateCartDto.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _cartService.UpdateCartAsync(updateCartDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCartAsync(int id)
        {
            var result = await _cartService.DeleteCartAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
