using System;
using System.Collections.Generic;
using System.Text;

namespace TourOfHeroes.Domain.Models
{
    public class BaseEntity
    {
        public Guid Id { get; private set; }
    }
}
