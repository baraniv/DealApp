using System.Collections.Generic;
using System.Threading.Tasks;
using DealApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace DealApp.API.Data
{
    public class CityRepository
    {

        private readonly DataContext _context;
        public CityRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<City>> GetCities()
        {
            var cities = await _context.Cities.ToListAsync();
            return cities;
        }

        public async Task<City> GetCity(int id)
        {
            var city = await _context.Cities.FirstOrDefaultAsync(u => u.Id == id);
            return city;
        }
    }
}