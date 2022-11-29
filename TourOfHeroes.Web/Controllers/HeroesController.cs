using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourOfHeroes.Domain.Interfaces;
using TourOfHeroes.Domain.Models;
using TourOfHeroes.Domain.Services;

namespace TourOfHeroes.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroesController : Controller
    {
        private readonly HeroService _heroesService;
        private readonly IRepository<Hero> _heroesRepository;

        public HeroesController(IRepository<Hero> heroesRepository, HeroService heroService)
        {
            _heroesService = heroService;
            _heroesRepository = heroesRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("GetAll/{test}")]
        public IEnumerable<Hero> GetHeroes(string test = "") 
        {
            var heroes = _heroesRepository.GetAll();
            return heroes;
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<Hero> GetHero(Guid id)
        {
            var hero = _heroesRepository.GetById(id);

            if (hero == null)
                return NotFound(new { message = $"Contato de id={id} não encontrado" });

            return hero;
        }

    }
}
