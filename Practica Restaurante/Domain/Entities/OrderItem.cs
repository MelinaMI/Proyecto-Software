using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderItem
    {
        public long OrderItemId { get; set; }
        public long Order { get; set; } //FK
        public Guid Dish {  get; set; } //FK
        public int Quantity { get; set; }
        public string Notes { get; set; }
        public int Status { get; set; } //FK
        public DateTime CreateDate { get; set; }

    }
}
