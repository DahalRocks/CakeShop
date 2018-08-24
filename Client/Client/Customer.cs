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
        private static System.Random random = new Random();
        public Customer() { this.CustomerID = random.Next(); }
       
    }
}
