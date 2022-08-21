using System;
using Microsoft.EntityFrameworkCore;
using OnionStart.Application.Interfaces.Repositories;
using OnionStart.Domain.Entities.Base;
using OnionStart.Persistance.Context;

namespace OnionStart.Persistance.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T:BaseEntity
    {
        private readonly ProniaDbContext _context;

        public GenericRepository(ProniaDbContext context)
        {
            this._context = context;
        }


        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async  Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            List<T> values =await _context.Set<T>().ToListAsync();
            return values;
        }

        public async Task<T> GetById(int id)
        {
            T value = await _context.Set<T>().FirstOrDefaultAsync(t => t.Id == id);
            return value;
        }
    }
}

