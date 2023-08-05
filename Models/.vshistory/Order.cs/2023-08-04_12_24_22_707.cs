﻿namespace BethanysPieShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

    }
}
