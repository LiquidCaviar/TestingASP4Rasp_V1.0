using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingASP4Rasp_V1._0.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public ICollection<OrderItem> Items { get; set; }
    }
}
