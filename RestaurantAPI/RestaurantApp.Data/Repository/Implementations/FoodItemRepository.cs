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
    public class FoodItemRepository : GenericRepository<FoodItemRepository>, IFoodItemRepository
    {
        private readonly Context _dbContext;

        public FoodItemRepository(Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<FoodItem> GetFoodItemById(int foodItemId)
        {
            return await _dbContext.FoodItems
                .FirstOrDefaultAsync(x => x.FoodId == foodItemId);
        }

        public async Task<List<FoodItem>> GetAllFoodItems() 
        {
            return await _dbContext.FoodItems
                .Include(x => x.FoodItemName)
                .Include(y => y.Price).ToListAsync();
        }



    }
}
