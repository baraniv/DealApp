using System.Collections.Generic;
using System.Threading.Tasks;
using DealApp.API.Models;
using System;

namespace DealApp.API.Data
{
    public interface IDealRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll(); 
        Task<IEnumerable<Property>> GetProperties();
        Task<Property> GetProperty(int id);
    }
}