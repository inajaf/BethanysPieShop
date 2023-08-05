namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository categoryRepository = new MockCategoryRepository();
        IEnumerable<Pie> IPieRepository.AllPies => 
            new List<Pie>;

        IEnumerable<Pie> IPieRepository.PiesOfTheWeek => throw new NotImplementedException();

        Pie? IPieRepository.GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
