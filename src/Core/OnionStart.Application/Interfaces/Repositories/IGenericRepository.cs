using System;
namespace OnionStart.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T:BaseEntity
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetById(int id);

        void AddAsync(T entity);

        void DeleteAsync(int id);
    }
}

