﻿namespace BethanysPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BethanysPieShopDbContext

        public IEnumerable<Category> AllCategories => throw new NotImplementedException();
    }
}
