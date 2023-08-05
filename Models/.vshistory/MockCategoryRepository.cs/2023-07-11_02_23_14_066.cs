namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        IEnumerable<Category> ICategoryRepository.AllCategories => throw new NotImplementedException();
    }
}
