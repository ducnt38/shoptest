﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Data.Infrastructure
{
    public class DBFactory : Disposable, IDbFactory
    {
        private ShopDbContext dbContext;

        public ShopDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
