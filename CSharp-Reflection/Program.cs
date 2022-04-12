using System;
using ClassLibrary;
namespace CSharp_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order()
            {
                ProductCount = 1,
                TotalAmount = 20,
                CreatedAt = DateTime.Parse("10/01/2022"),
            };
            Order order2 = new Order()
            {
                ProductCount = 1,
                TotalAmount = 30,
                CreatedAt = DateTime.Parse("10/01/2021"),
            };
            Order order3 = new Order()
            {
                ProductCount = 1,
                TotalAmount = 40,
                CreatedAt = DateTime.Parse("10/01/2020"),
            };
            Shop shop = new Shop();
            shop.AddOrder(order1);
            shop.AddOrder(order2);
            shop.AddOrder(order3);
            DateTime date = DateTime.Parse("09/01/2021");
            Console.WriteLine("==============Get orders avg with datetime==============");
            Console.WriteLine(shop.GetOrdersAvg(date));
            Console.WriteLine("==============Get orders avg==============");
            Console.WriteLine(shop.GetOrdersAvg());
            Console.WriteLine("==============Filter order by Price==============");
            foreach (var item in shop.FilterOrderByPrice(25, 55))
            {
                Console.WriteLine($"product no: {item.No} | product price: {item.TotalAmount}");
            };
            shop.RemoveOrderByNo(2);
            Console.WriteLine("==============After remove product==============");
            foreach (var item in shop.Orders)
            {
                Console.WriteLine($"product no: {item.No} | product price: {item.TotalAmount} | product created at: {item.CreatedAt}");
            }
            
        }
    }
}
