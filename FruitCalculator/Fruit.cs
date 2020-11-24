using System;
using System.Collections.Generic;
using System.Text;

namespace FruitCalculator
{
    public class Fruit
    {
        public string Name { get; set; }
        public decimal price { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; } = 0;
    }
}
