using System;
using System.Linq;

namespace Sun.Domain
{
    /// <summary>
    /// Repositório genérico que disponibiliza os métodos do CRUD.
    /// </summary>
    /// <typeparam name="TEntity">Repositório para a entidade passada.</typeparam>
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(Guid id);
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();
        int SaveChanges();
    }
}
