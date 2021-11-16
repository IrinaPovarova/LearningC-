using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Products
{
    class Garlic : FoodBase
    {
        public Garlic(int weight)
        {
            Name = "Garlic";
            Calories = 140;
            Weight = weight;
        }
        public override ProductType ProductType => ProductType.Vegetables;

    }
}
