using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Repository.Interfaces
{
    public interface IOrderDetailRepository
    {
        Task<OrderDetail> GetOrderDetailById(long orderDetailId);
    }
}
