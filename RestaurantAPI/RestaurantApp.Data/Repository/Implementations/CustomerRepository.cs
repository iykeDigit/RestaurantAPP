using Microsoft.EntityFrameworkCore;
using RestaurantApp.Data.Repository.Interfaces;
using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Repository.Implementations
{
    public class CustomerRepository : GenericRepository<CustomerRepository>, ICustomerRespository
    {
        private readonly Context _dbContext;

        public CustomerRepository(Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _dbContext.Customers
                .Include(x => x.CustomerName).ToListAsync();
        }

        public async Task<Customer> GetCustomerById(int customerId)
        {
            return await _dbContext.Customers
                .FirstOrDefaultAsync(x => x.CustomerId == customerId);
        }
    }
}
