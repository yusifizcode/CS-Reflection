using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Order
    {
        public Order()
        {
            _no++;
            No = _no;
        }
        static int _no;
        public int No { get; set; }
        public int ProductCount { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
