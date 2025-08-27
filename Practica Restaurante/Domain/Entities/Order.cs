using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        public long OrderId { get; set; } //PK
        public int DeliveryType { get; set; } //FK
        public string DeliveryTo { get; set; }
        public int OverallStatus { get; set; } //FK
        public string Notes { get; set; }
        public decimal Price { get; set; }
        public DateTime  CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }


    }
}
