﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TourOfHeroes.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
