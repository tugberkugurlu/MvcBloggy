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

        public virtual PaginatedList<T> Paginate<TKey>(
            int pageIndex, int pageSize, 
            Expression<Func<T, TKey>> keySelector) {

            return Paginate(pageIndex, pageSize, keySelector, null);
        }

        public virtual PaginatedList<T> Paginate<TKey>(
            int pageIndex, int pageSize,
            Expression<Func<T, TKey>> keySelector,
            Expression<Func<T, bool>> predicate,
            params Expression<Func<T, object>>[] includeProperties) {

            IQueryable<T> query = AllIncluding(includeProperties).OrderBy(keySelector);
            query = (predicate == null) ? query : query.Where(predicate);

            var baseQuery = query;
            
            query = query.Skip((pageIndex - 1)* pageSize).Take(pageSize);
            var totalCount = baseQuery.Count();
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