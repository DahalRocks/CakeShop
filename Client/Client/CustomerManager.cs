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
            try
            {
                lstCustomer.Add(customer);
            }
            catch (NullReferenceException e)
            {

                throw e;
            }
            
        }
        public static bool CheckCustomer(string name)
        {
            try
            {
                Customer c = new Customer() { CustomerName = name };
                return lstCustomer.Contains(c) ? true : false;
            }
            catch (NullReferenceException e)
            {
                throw e;
            }
            
        }
        public static void ExtractCustomerSortedByName()
        {
            if (lstCustomer.Count > 0)
            {
                var sortedList = lstCustomer.OrderBy(c => c.CustomerName).ToList<Customer>();
                Console.WriteLine("The sorted list of registered customers:");
                foreach (var c in sortedList)
                {
                    Console.WriteLine(c.CustomerName);
                }
            }
            
        }
    }
}
