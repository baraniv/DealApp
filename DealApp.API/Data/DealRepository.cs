using System.Collections.Generic;
using System.Threading.Tasks;
using DealApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DealApp.API.Data
{
    public class DealRepository : IDealRepository
    {
        private readonly DataContext _context;
        public DealRepository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<IEnumerable<Property>> GetProperties()
        {
            var properties = await _context.Properties.Include(p => p.Photos).ToListAsync();
            return properties;
        }

        public async Task<Property> GetProperty(int id)
        {
            var property = await _context.Properties.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);
            return property;
        }

        public async Task<bool> SaveAll()
        {
           return await _context.SaveChangesAsync() > 0; 
        }
    }
}