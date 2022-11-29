using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TourOfHeroes.Domain.Interfaces;
using TourOfHeroes.Domain.Models;
using TourOfHeroes.Domain.Services;
using TourOfHeroes.Infra.Context;
using TourOfHeroes.Infra.Repositories;

namespace TourOfHeroes.Application.DI
{
    public class Initializer
    {
        public static void Configure(IServiceCollection services, string connection)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

            services.AddScoped(typeof(IRepository<Hero>), typeof(HeroRepository));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(HeroService));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}
