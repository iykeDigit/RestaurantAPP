using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class FoodItem
    {
        [Key]
        public int FoodId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string FoodItemName { get; set; }
        public decimal Price { get; set; }

    }
}
