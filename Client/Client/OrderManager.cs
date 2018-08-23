using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class OrderManager
    {
        public static List<Order> FinalOrderList = new List<Order>();
        public static bool RegisterOrder(Order order)
        {
            bool result = true;
            try
            {
                FinalOrderList.Add(order);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }
            return result;
        }
        public static void GetDeliveredOrderFor(Customer customer)
        {
            var deliveredOrderList = from order in FinalOrderList
                                     where order.CustomerWithOrder.CustomerID == customer.CustomerID && order.IsDelivered == true
                                     select order;
            foreach (var delivery in deliveredOrderList)
            {
                Console.WriteLine(delivery.OrderID);
            }
        }
        public static void ChangeOrderStatusToDelivered(Order order)
        {
            var ord = from lst in FinalOrderList
                      where lst.OrderID == order.OrderID
                      select lst;
            foreach (var o in ord)
            {
                o.IsDelivered = true;
                o.DeliveredDate = System.DateTime.Now;
            }
        }
        /*public int GetMostDelayedDelivery()
        {
            if (FinalOrderList.Count != 0)
            {
                foreach(var list in FinalOrderList)
                {
                    list.OrderedDate
                }
            }
            var order=from lst in FinalOrderList
                      where lst.OrderedDate-lst.DeliveredDate
        }*/


    }
}
