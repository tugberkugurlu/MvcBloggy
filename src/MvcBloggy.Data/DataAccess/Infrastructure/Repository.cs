using System;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;

namespace MvcBloggy.Data.DataAccess.Infrastructure {

    public abstract class Repository<T, C> : IRepository<T, C> where T : class where C : DbContext, new() {

        private C _entities = new C();

        public C Context {

            get { return _entities; }
            set { _entities = value; }
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate) {

            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }

        public void Add(T entity) {
            _entities.Set<T>().Add(entity);
        }

        public void Delete(T entity) {
            _entities.Set<T>().Remove(entity);
        }

        public void Edit(T entity) {
            _entities.Entry(entity).State = System.Data.EntityState.Modified;
        }

        public void Save() {
            _entities.SaveChanges();
        }
    }
}