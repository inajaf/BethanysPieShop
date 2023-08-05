namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        IEnumerable<Category> ICategoryRepository.AllCategories => 
            new List<Category>()
            {
                new Category()
            }
    }
}
