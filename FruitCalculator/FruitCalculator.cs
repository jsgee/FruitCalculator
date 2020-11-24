using System;
using System.Collections.Generic;
using System.Text;

namespace FruitCalculator
{
    public class FruitCalculator
    { 
public decimal Calculate(List<Fruit> fruitList)
        {
            decimal total = 0;

            foreach (var fruit in fruitList)
            {
                if (fruit.Discount  == 0)
                {
                    total += fruit.price * fruit.Quantity;
                }

               if (fruit.Discount > 0)
                {
                    total += fruit.Discount * fruit.price * fruit.Quantity;
                }
            }
            
            return total;
        }
    }
}
