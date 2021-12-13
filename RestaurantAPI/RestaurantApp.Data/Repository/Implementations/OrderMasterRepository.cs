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
    public class OrderMasterRepository : GenericRepository<OrderMasterRepository>, IOrderMasterRepository
    {
        private readonly Context _dbContext;

        public OrderMasterRepository(Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<OrderMaster>> GetALlOrderMasters()
        {
            return await _dbContext.OrderMasters
                .Include(x => x.Customer)
                .Include(x => x.GrandTotal)
                .Include(x => x.OrderDetails)
                .Include(x => x.OrderNumber)
                .Include(x => x.PaymentMethod).ToListAsync();
        }

        public async Task<OrderMaster> GetOrderMasterById(long orderMasterId)
        {
            return await _dbContext.OrderMasters
                .Include(x => x.Customer)
                .Include(x => x.GrandTotal)
                .Include(x => x.OrderDetails)
                .Include(x => x.OrderNumber)
                .Include(x => x.PaymentMethod).
                FirstOrDefaultAsync(x => x.OrderMasterId == orderMasterId);
        }
    }
}
