using OOP.Meals;
using System;
using System.Collections.Generic;
using System.Text;
using Exceptions;


namespace OOP
{
    class Borsch : MealBase
    {

        public Borsch(FoodBase[] products) : base(products)
        {
            MealName = "Borsch";
            Console.WriteLine($"Cook dinner");
            Console.WriteLine("**********************************************************");
            Console.WriteLine($"{MealName}:");
        }

        public void FindPoductWieghInIntervalForBorsch()
        {
            int count = 0;
            int minWeight = 0, maxWeight = 0;


                Console.WriteLine("Enter min weight");
                minWeight = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter max weight");
                maxWeight = int.Parse(Console.ReadLine());
                //maxInt 2147483647

                if (maxWeight <= minWeight)
                {
                    throw new IntervalException("Right interval border < Left interval border");
                }
                else
                {
                    if (maxWeight < 0 || minWeight < 0)
                    {
                        throw new IntervalException("Wrong interval border");
                    }
                }



            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"Product weight in Borsch within the defined interval [{minWeight} - {maxWeight}]g");
            foreach (var item in _products)
            {
                if (item.Weight >= minWeight & item.Weight <= maxWeight)
                {
                    Console.WriteLine($"{item.Name} - {item.Weight}");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No products with weight in the defined interval");
            }
        }


        public override void Cook()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("How to cook borsch:");
            Console.WriteLine("Boil Meat");
            Console.WriteLine("Cut Cabbage, Carrot, Onion, Potato, Beet");
            Console.WriteLine("Fry Carrot, Onion in Sun Flower Oil");
            Console.WriteLine("Boil Cabbage, Carrot, Onion, Potato, Beet");
            Console.WriteLine("Add Salt, Peper, Sour Cream");
        }
    }
}
