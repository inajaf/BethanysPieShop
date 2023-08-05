namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        IEnumerable<Pie> IPieRepository.AllPies => throw new NotImplementedException();

        IEnumerable<Pie> IPieRepository.PiesOfTheWeek => throw new NotImplementedException();

        Pie? IPieRepository.GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
