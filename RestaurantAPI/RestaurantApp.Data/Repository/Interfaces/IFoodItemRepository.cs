using RestaurantApp.Data.Repository.Implementations;
using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Repository.Interfaces
{
    public interface IFoodItemRepository : IGenericRepository<FoodItemRepository>
    {
        Task<FoodItem> GetFoodItemById(int foodItemId);
        Task<List<FoodItem>> GetAllFoodItems();
    }
}
