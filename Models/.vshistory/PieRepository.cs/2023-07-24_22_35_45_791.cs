﻿namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly BethanysPieShopDbContext _bethanysPieShopDbContext;

        public PieRepository(BethanysPieShopDbContext bethanysPieShopDbContext)
        {
            _bethanysPieShopDbContext = bethanysPieShopDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _bethanysPieShopDbContext.
            }
        }

        IEnumerable<Pie> IPieRepository.PiesOfTheWeek => throw new NotImplementedException();

        Pie? IPieRepository.GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
