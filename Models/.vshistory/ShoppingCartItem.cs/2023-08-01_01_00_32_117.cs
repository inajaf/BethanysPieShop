﻿namespace BethanysPieShop.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Pie Pie { get; set; } = default!;
        public int Amoutn { get; set; }

    }
}
