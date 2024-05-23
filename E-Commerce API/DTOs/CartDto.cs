using System.Collections.Generic;

namespace E_Commerce_API.DTOs
{
    public class CartDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ICollection<CartItemDto> CartItems { get; set; }
    }

    public class CreateCartDto
    {
        public string UserId { get; set; }
        public ICollection<CreateCartItemDto> CartItems { get; set; }
    }

    public class UpdateCartDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ICollection<UpdateCartItemDto> CartItems { get; set; }
    }
}
