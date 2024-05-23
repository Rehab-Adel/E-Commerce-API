using System.ComponentModel.DataAnnotations;

namespace E_Commerce_API.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0.01, 999999.99)]
        public decimal Price { get; set; }
    }
}
