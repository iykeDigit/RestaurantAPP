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
    public class OrderDetailRepository : GenericRepository<OrderDetailRepository>, IOrderDetailRepository
    {
        private readonly Context _dbContext;

        public OrderDetailRepository(Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OrderDetail> GetOrderDetailById(long orderDetailId)
        {
            return await _dbContext.OrderDetails
                .FirstOrDefaultAsync(x => x.OrderDetailId == orderDetailId);
        }

        public async Task<List<OrderDetail>> GetAllOrderDetails() 
        {
            return await _dbContext.OrderDetails
                .Include(x => x.FoodItem)
                .Include(x => x.FoodItemPrice)
                .Include(x => x.Quantity)
                .Include(x => x.OrderMaster)
                .ToListAsync();
        }
    }
}
