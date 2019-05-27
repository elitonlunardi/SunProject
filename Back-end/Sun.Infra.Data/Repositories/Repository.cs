
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Sun.Domain;

namespace Sun.Infra.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected readonly SunContext _db;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(SunContext context)
        {
            _db = context;
            _dbSet = _db.Set<TEntity>();
        }

        public void Add(TEntity obj)
        {
            _dbSet.Add(obj);
        }

        public void Remove(Guid id)
        {
            _dbSet.Remove(_dbSet.Find(id));
        }
        public void Update(TEntity obj)
        {
            _dbSet.Update(obj);
        }
        public TEntity GetById(Guid id)
        {
            return _dbSet.Find(id);
        }
        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }
        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
