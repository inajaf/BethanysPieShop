using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.ViewModels
{
    public class ShoppingCartViewModel
    {
       public ShoppingCartViewModel(IShoppingCart shoppingCart, decimal shoppingCartTotal) 
       {
            ShoppingCart = shoppingCart;
            ShoppingCartTotal = shoppingCartTotal;
       }
    }
}
