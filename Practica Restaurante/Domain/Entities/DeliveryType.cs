using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DeliveryType
    {
        public int Id { get; set; } //PK
        public string Name { get; set; }
    }
}
