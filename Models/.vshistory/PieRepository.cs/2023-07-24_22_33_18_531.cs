﻿namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly BethanysPieShopDbContext context;

        public IEnumerable<Pie> AllPies => throw new NotImplementedException();

        public IEnumerable<Pie> PiesOfTheWeek => throw new NotImplementedException();

        public Pie? GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
