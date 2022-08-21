using System;
using OnionStart.Domain.Entities.Base;

namespace OnionStart.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T:BaseEntity
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetById(int id);

        Task<T> AddAsync(T entity);

        Task DeleteAsync(T entity);
    }
}

