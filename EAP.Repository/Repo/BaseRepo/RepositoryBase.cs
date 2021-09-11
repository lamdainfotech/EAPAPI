using System;
using System.Linq;
using System.Linq.Expressions;
using EAP.Contracts.IRepositoty.BaseRepo;
using EAP.Entity.Data;
using Microsoft.EntityFrameworkCore;

namespace EAP.Repository.Repo.BaseRepo
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly EAPDbContext _context;

        protected RepositoryBase(EAPDbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}