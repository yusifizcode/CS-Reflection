using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Shop
    {
        public List<Order> Orders = new List<Order>();
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public double GetOrdersAvg()
        {
            double sum = 0;
            int count = 0;
            foreach (Order order in Orders)
            {
                sum += order.TotalAmount;
                count++;
            }
            return sum / count;
        }

        public double GetOrdersAvg(DateTime dateTime)
        {
            double sum = 0;
            int count = 0;
            foreach (Order order in Orders)
            {
                if (dateTime<order.CreatedAt)
                {
                    sum += order.TotalAmount;
                    count++;
                }
            }
            return sum / count;
        }

        public void RemoveOrderByNo(int no)
        {
            var item = Orders.Find(x => x.No == no);
            Orders.Remove(item);
        }

        public List<Order> FilterOrderByPrice(double minPrice, double maxPrice)
        {
            return Orders.FindAll(x => x.TotalAmount > minPrice && x.TotalAmount < maxPrice);
        }
    }
}
