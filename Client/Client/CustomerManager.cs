using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class CustomerManager
    {
        public static List<Customer> lstCustomer = new List<Customer>();
        public static void RegisterNewCustomer(Customer customer)
        {
            lstCustomer.Add(customer);
        }
        public bool CheckCustomer(string name)
        {
            Customer c = new Customer() { CustomerName = name };
            return lstCustomer.Contains(c) ? true : false;
        }
        public static void ExtractCustomerSortedByName()
        {
            var sortedList = lstCustomer.OrderBy(c => c.CustomerName).ToList<Customer>();
            foreach (var c in sortedList)
            {
                Console.WriteLine(c.CustomerName);
            }
        }
    }
}
