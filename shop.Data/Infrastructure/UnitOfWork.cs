using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Data.Infrastructure
{
    public class UnitOfWork : IUniOfWork
    {
        private readonly IDbFactory dbFactory;
        private ShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory) 
        {
            this.dbFactory = dbFactory;
        }

        public ShopDbContext Dbcontext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            dbContext.SaveChanges();
        }
    }
}
