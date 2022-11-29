using System;
using System.Collections.Generic;
using System.Text;
using TourOfHeroes.Domain.Interfaces;
using TourOfHeroes.Domain.Models;

namespace TourOfHeroes.Domain.Services
{
    public class HeroService
    {
        private readonly IRepository<Hero> _heroRepository;

        public HeroService()
        {
        }

        public void Save(Guid id, string name, string alterEgo)
        {
            var hero = _heroRepository.GetById(id);

            if (hero == null)
            {
                hero = new Hero(name, alterEgo);
                _heroRepository.Save(hero);
            }
            else
                hero.Update(name, alterEgo);
        }
    }
}
