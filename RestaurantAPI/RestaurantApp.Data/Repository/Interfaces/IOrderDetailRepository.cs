using RestaurantApp.Data.Repository.Implementations;
using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Repository.Interfaces
{
    public interface IOrderDetailRepository : IGenericRepository<OrderDetailRepository>
    {
        Task<OrderDetail> GetOrderDetailById(long orderDetailId);
        Task<List<OrderDetail>> GetAllOrderDetails();
    }
}
