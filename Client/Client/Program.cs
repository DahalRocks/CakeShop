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
            Customer cos = new Customer(){CustomerName = "Ramesh"};
            CustomerManager.RegisterNewCustomer(cos);
            Dictionary<string, int> orderList = new Dictionary<string, int>();
            orderList.Add("KranseKaker", 1);
            orderList.Add("ChocolateKake", 1);
            orderList.Add("BløtKake", 1);
            Order orderOne = new Order() { CakeOrder = orderList, CustomerWithOrder = cos, OrderedDate = System.DateTime.Now };
            if (OrderManager.RegisterOrder(orderOne))
                Console.WriteLine("Registration is successful");
            else
                Console.WriteLine("Problem with registration");
            CustomerManager.ExtractCustomerSortedByName();
            OrderManager.ChangeOrderStatusToDelivered(orderOne);
            OrderManager.GetDeliveredOrderFor(cos);
            Console.ReadKey();
        }
    }
}
