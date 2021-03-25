using System.Collections.Generic;
using System.Threading.Tasks;
using DealApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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
            var properties = await _context.Properties
            .Include(p => p.Photos)
            .Include( u => u.City)
            .Include( u => u.Quarter)
            .Include( u => u.Area)
            .Include( u => u.Block)
            .Include( u => u.Category)
            .Include( u => u.Floor)
            .Include( u => u.Interface)
            .Include( u => u.Project)
            .Include( u => u.PropertyType)
            .Include( u => u.Tower)
            .Include( u => u.Renter)
            .ToListAsync();
            
            return properties;
        }

        public async Task<Property> GetProperty(int id)
        {
            var property = await _context.Properties
            .Include(p => p.Photos)
            .Include( u => u.City)
            .Include( u => u.Quarter)
            .Include( u => u.Area)
            .Include( u => u.Block)
            .Include( u => u.Category)
            .Include( u => u.Floor)
            .Include( u => u.Interface)
            .Include( u => u.Project)
            .Include( u => u.PropertyType)
            .Include( u => u.Tower)
            .Include( u => u.Renter)
            .FirstOrDefaultAsync( u => u.Id == id);

            // var property = await _context.Properties
            // .FirstOrDefaultAsync( u => u.Id == id);
            
            return property;
        }

        public async Task<bool> SaveAll()
        {
           return await _context.SaveChangesAsync() > 0; 
        }
    }
}