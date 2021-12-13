using RestaurantApp.Data.Repository.Implementations;
using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Repository.Interfaces
{
    public interface IOrderMasterRepository : IGenericRepository<OrderMasterRepository>
    {
        Task<OrderMaster> GetOrderMasterById(long orderMasterId);
        Task<List<OrderMaster>> GetALlOrderMasters();
    }
}
