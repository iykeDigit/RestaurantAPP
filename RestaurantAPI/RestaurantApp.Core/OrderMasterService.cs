using RestaurantApp.Data;
using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Core
{
    public class OrderMasterService : IOrderMasterService
    {
        private Context _context;
        public OrderMasterService(Context context)
        {
            _context = context;
        }
        public async Task DeleteOrderMaster(long id)
        {
            var orderMaster = await _context.OrderMasters.FindAsync(id);
            if(orderMaster == null) 
            {
                throw new ArgumentException("Order master doesn't exist");
            }
            _context.OrderMasters.Remove(orderMaster);
            await _context.SaveChangesAsync();
        }

        public Task<IEnumerable<OrderMaster>> GetAllOderMasters()
        {
            throw new NotImplementedException();
        }

        public Task<OrderMaster> GetOrderMasterById(long orderMasterId)
        {
            throw new NotImplementedException();
        }

        public Task<OrderMaster> PostOrderMaster(OrderMaster orderMaster)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderMaster(long id)
        {
            throw new NotImplementedException();
        }

        private bool OrderMasterExists(long id)
        {
            return _context.OrderMasters.Any(e => e.OrderMasterId == id);
        }
    }
}
