using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericRepository;

namespace MvcBloggy.Tests.Fakes {

    internal class FakeRepository<T> : IRepository<T> where T : class {

        public void Add(T entity) {
            throw new NotImplementedException();
        }

        public IQueryable<T> All {
            get { throw new NotImplementedException(); }
        }

        public IQueryable<T> AllIncluding(params System.Linq.Expressions.Expression<Func<T, object>>[] includeProperties) {
            throw new NotImplementedException();
        }

        public void Delete(T entity) {
            throw new NotImplementedException();
        }

        public void Edit(T entity) {
            throw new NotImplementedException();
        }

        public T Find(params object[] keyValues) {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate) {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll() {
            throw new NotImplementedException();
        }

        public void Save() {
            throw new NotImplementedException();
        }

        public void Upsert(T entity, Func<T, bool> insertExpression) {
            throw new NotImplementedException();
        }

        public void Dispose() {
            throw new NotImplementedException();
        }
    }
}