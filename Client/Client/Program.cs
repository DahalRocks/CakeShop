using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //create and initialize customer objects
            Customer customerOne = new Customer(){CustomerName = "Ramesh"};
            Customer customerTwo = new Customer(){CustomerName = "Dhruba"};
            Customer customerThree = new Customer(){CustomerName = "Erik"};
            //register customers to the system
            CustomerManager.RegisterNewCustomer(customerOne);
            CustomerManager.RegisterNewCustomer(customerTwo);
            CustomerManager.RegisterNewCustomer(customerThree);
            //create collection object for cake and quantity selected by a customer
            Dictionary<string, int> orderList = new Dictionary<string, int>();
            orderList.Add("KranseKaker", 1);
            orderList.Add("ChocolateKake", 1);
            orderList.Add("BløtKake", 1);
            //create order for the customers
            Order orderOne = new Order() { CakeOrder = orderList, CustomerWithOrder = customerOne, OrderedDate = System.DateTime.Now };
            Order orderTwo = new Order() { CakeOrder = orderList, CustomerWithOrder = customerTwo, OrderedDate = System.DateTime.Now };
            Order orderThree = new Order() { CakeOrder = orderList, CustomerWithOrder = customerThree, OrderedDate = System.DateTime.Now };
            //register order for the customer
            OrderManager.RegisterOrder(orderOne);
            //display registered customers sorted by alphabet(ascending order) 
            CustomerManager.ExtractCustomerSortedByName();
            //mark order as a  successfully delivered 
            OrderManager.ChangeOrderStatusToDelivered(orderOne);
            //display successful delivery for a particular customer
            OrderManager.GetDeliveredOrderFor(customerOne);
            //display most lazy delivery in a whole delivery
            OrderManager.GetMostDelayedDelivery();
            Console.ReadKey();
        }
    }
}
