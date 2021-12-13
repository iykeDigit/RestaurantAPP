using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class OrderDetail
    {
        public long OrderDetailId { get; set; }
        public long OrderMasterId { get; set; }
        public int FoodItemId { get; set; }
        public decimal FoodItemPrice { get; set; }
        public int Quantity { get; set; }
        public OrderMaster OrderMaster { get; set; }
        public FoodItem FoodItem { get; set; }
        
    }
}
