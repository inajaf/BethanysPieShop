namespace BethanysPieShop.Models
{
    public class ShoppingCart: IShoppingCart
    {
        private readonly BethanysPieShopDbContext bethanysPieShopDbContext;
        public string? ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;

       
    }
}
