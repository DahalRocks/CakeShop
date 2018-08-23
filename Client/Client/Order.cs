using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Order
    {
        public int OrderID { get; set; }
        public Customer CustomerWithOrder { get; set; }
        public Dictionary<string, int> CakeOrder { get; set; }
        public bool IsDelivered { get; set; }
        public DateTime OrderedDate { get; set; }
        public DateTime DeliveredDate { get; set; }
        public Order()
        {
            Random random = new Random();
            this.OrderID = random.Next();
            this.IsDelivered = false;
        }
    }
}
