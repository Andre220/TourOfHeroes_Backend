using System;
using System.Collections.Generic;
using System.Text;

namespace TourOfHeroes.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity: class
    {
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        void Save(TEntity entity);
    }
}
