using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace shop.Data.Infrastructure
{
    public class RepositoryBase<T> where T : class
    {
        #region Properties
        private ShopDbContext dataContext;
        private readonly IDbSet<T> dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected ShopDbContext DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }
        #endregion
        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
        }

        #region Implementation
        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void DeleteMulti(Expression<Func<T, bool>> where)
        {
            IEnumerable
        }
        #endregion
    }
}
