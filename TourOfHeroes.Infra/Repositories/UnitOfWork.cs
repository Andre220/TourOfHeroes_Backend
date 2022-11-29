using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourOfHeroes.Domain.Interfaces;
using TourOfHeroes.Infra.Context;

namespace TourOfHeroes.Infra.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
