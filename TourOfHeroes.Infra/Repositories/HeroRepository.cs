using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourOfHeroes.Domain.Models;
using TourOfHeroes.Infra.Context;

namespace TourOfHeroes.Infra.Repositories
{
    public class HeroRepository : Repository<Hero>
    {
        public HeroRepository(AppDbContext appDbContext) : base(appDbContext)
        {}

        public override Hero GetById(Guid id)
        {
            var query = _context.Set<Hero>().Where(x => x.Id == id);

            if (query.Any())
                return query.SingleOrDefault();

            return null;
        }

        public override IEnumerable<Hero> GetAll()
        {
            var query = _context.Set<Hero>();

            if (query.Any())
                return query.ToList();

            return new List<Hero>();
        }
    }
}
