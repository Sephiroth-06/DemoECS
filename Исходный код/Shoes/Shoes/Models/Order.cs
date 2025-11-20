using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int PickupPointId { get; set; }
        public int UserId { get; set; }
        public string ReceiptCode { get; set; }
        public int StatusId { get; set; }

        // Навигационные свойства
        public PickupPoint PickupPoint { get; set; }
        public User User { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderArticle> OrderArticles { get; set; } = new List<OrderArticle>();
    }
}
