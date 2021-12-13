using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Core
{
    public interface IOrderMasterService
    {
        Task<IEnumerable<OrderMaster>> GetAllOderMasters();
        Task<OrderMaster> GetOrderMasterById(long orderMasterId);
        Task UpdateOrderMaster(long id);
        Task<OrderMaster> PostOrderMaster(OrderMaster orderMaster);
        Task DeleteOrderMaster(long id);

    
    }
}
