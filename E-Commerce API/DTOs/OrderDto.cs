using System;
using System.Collections.Generic;

namespace E_Commerce_API.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
        public ICollection<OrderItemDto> OrderItems { get; set; }
    }

    public class CreateOrderDto
    {
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
        public ICollection<CreateOrderItemDto> OrderItems { get; set; }
    }

    public class UpdateOrderDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
        public ICollection<UpdateOrderItemDto> OrderItems { get; set; }
    }
}
