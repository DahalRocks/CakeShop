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
        public static void RegisterOrder(Order order)
        {
            try
            {
                FinalOrderList.Add(order);
            }
            catch (NullReferenceException e)
            {

                throw e;
            }
            
        }
        public static void GetDeliveredOrderFor(Customer customer)
        {
            if (customer != null)
            {
                var deliveredOrderList = from order in FinalOrderList
                                         where order.CustomerWithOrder.CustomerID == customer.CustomerID && order.IsDelivered == true
                                         select order;
                foreach (var delivery in deliveredOrderList)
                {
                    Console.WriteLine($"This is a successful delivery having OrderID:{delivery.OrderID} for the customer named:{delivery.CustomerWithOrder.CustomerName}");
                }
            }
            else
                throw new NullReferenceException();
            
        }
        public static void ChangeOrderStatusToDelivered(Order order)
        {
            try
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
            catch (NullReferenceException e)
            {
                throw e;
            }
        }
        public static void GetMostDelayedDelivery()
        {
            Dictionary<TimeSpan, int> orderPeriod = new Dictionary<TimeSpan, int>();
            if (FinalOrderList.Count > 0)
            {
                foreach (var lst in FinalOrderList)
                {
                        TimeSpan timeDifference = lst.DeliveredDate - lst.OrderedDate;
                        orderPeriod.Add(timeDifference,lst.OrderID);
                }
                var lazyDelivery = from ord in orderPeriod
                                   where ord.Key == orderPeriod.Keys.Max()
                                   select ord;
                foreach (var list in lazyDelivery)
                {
                    Console.WriteLine($"The longest delivery time period: {list.Key} and this is for the order with OrderID:{list.Value}");
                }
            }
        }
    }
}
