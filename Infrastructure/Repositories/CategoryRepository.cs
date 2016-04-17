﻿using System.Collections.Generic;
using System.Data.Entity;
using Domain;
using System.Linq;
using Microsoft.SqlServer.Server;

namespace Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(SalesContext context) : base(context)
        {
            
        }
       
        public SalesContext SalesContext
        {
            get
            {
                return Context as SalesContext;
            }
        }
    }
}
