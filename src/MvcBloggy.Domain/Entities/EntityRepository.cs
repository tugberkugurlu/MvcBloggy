using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Domain.Entities {

    public class EntityRepository<T> : IEntityRepository<T>
        where T : class, IEntity, new() {

        readonly DbContext _entities;

        public EntityRepository(DbContext entities) {

            _entities = entities;
        }

        public virtual IQueryable<T> GetAll() {

            return _entities.Set<T>();
        }

        public virtual IQueryable<T> All {

            get {
                return GetAll();
            }
        }

        public virtual IQueryable<T> AllIncluding(
            params Expression<Func<T, object>>[] includeProperties) {

            IQueryable<T> query = _entities.Set<T>();
            foreach (var includeProperty in includeProperties) {

                query = query.Include(includeProperty);
            }

            return query;
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate) {

            return _entities.Set<T>().Where(predicate);
        }

        public PaginatedList<T> Paginate(int pageIndex, int pageSize) {

            return Paginate(null, pageIndex, pageSize);
        }

        public PaginatedList<T> Paginate(Expression<Func<T, object>> keySelector, int pageIndex, int pageSize) {

            return Paginate(null, keySelector, pageIndex, pageSize);
        }

        public virtual PaginatedList<T> Paginate(
            Expression<Func<T, bool>> predicate, 
            Expression<Func<T, object>> keySelector,
            int pageIndex, int pageSize) {

            IQueryable<T> query = _entities.Set<T>()
                .OrderBy(keySelector != null ? keySelector : x => x.Key);

            query = (predicate == null) ?
                query : query.Where(predicate);

            query = query.Skip((pageIndex - 1)* pageSize).Take(pageSize);

            var totalCount = _entities.Set<T>().Count();
            return new PaginatedList<T>(pageIndex, pageSize, totalCount, query);
        }

        public virtual void Add(T entity) {

            _entities.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity) {

            _entities.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity) {
            
            _entities.Entry(entity).State = System.Data.EntityState.Modified;
        }

        public virtual void Save() {

            _entities.SaveChanges();
        }
    }
}