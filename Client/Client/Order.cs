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
        private static Random random = new Random();
        public Order()
        {
            this.OrderID = random.Next();
            this.IsDelivered = false;
        }
    }
}
