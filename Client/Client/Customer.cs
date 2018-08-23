using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Customer
    {
        
            public int CustomerID { get; }
            public string CustomerName { get; set; }
            public Customer() { System.Random random = new Random(); this.CustomerID = random.Next(); }
       
    }
}
