using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace E_Commerce_API.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public ICollection<Cart> Carts { get; set; } = new List<Cart>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
