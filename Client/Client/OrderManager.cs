using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    /// <summary>
    /// Works with order object list creation and extraction
    /// </summary>
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
            Dictionary<int,TimeSpan> orderPeriod = new Dictionary<int,TimeSpan>();
            if (FinalOrderList.Count > 0)
            {
                foreach (var lst in FinalOrderList)
                {
                        TimeSpan timeDifference = lst.DeliveredDate - lst.OrderedDate;
                        orderPeriod.Add(lst.OrderID, timeDifference);
                }
                var lazyDelivery = from ord in orderPeriod
                                   where ord.Value == orderPeriod.Values.Max()
                                   select ord;
                foreach (var list in lazyDelivery)
                {
                    Console.WriteLine($"The longest delivery time period: {list.Value} and this is for the order with OrderID:{list.Key}");
                }
            }
        }
    }
}
