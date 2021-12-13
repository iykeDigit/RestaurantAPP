using Microsoft.EntityFrameworkCore;
using RestaurantApp.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Repository.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly Context _dbContext;
        private readonly DbSet<T> _table;
        public GenericRepository(Context dbContext)
        {
            _dbContext = dbContext;
            _table = _dbContext.Set<T>();
        }

        public async Task AddAsync(T data)
        {
            await _table.AddAsync(data);
        }

        public void Delete(T data)
        {
            _table.Remove(data);
        }

        public void Update(T data)
        {
            _table.Update(data);
        }
    }
}
