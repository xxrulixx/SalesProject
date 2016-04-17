﻿using System;
using Infrastructure.Repositories;

namespace Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Categories { get; }
        IProductRepository Products { get; }
        void Complete();
    }
}
