using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class OrderMaster
    {
        [Key]
        public long OrderMasterId { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        public string PaymentMethod { get; set; }
        public Customer Customer { get; set; }
        public decimal GrandTotal { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
