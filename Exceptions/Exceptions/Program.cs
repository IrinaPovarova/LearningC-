using Exceptions;
using OOP.Meals;
using OOP.Products;
using System;
using System.Collections.Generic;


namespace OOP
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var listForBorsch = new FoodBase[]
            {
                new Water(1500),
                new Beef(500),
                new Potato(300),
                new Cabbage(200),
                new Beet(200),
                new Carrot(200),
                new Onion(100),
                new SunFlowerOil(50),
                new Peper(5),
                new Salt(20),
                new SourCream(100),
                new Garlic(20)
            };
            bool isWeight0;
            var borsch = new Borsch(listForBorsch);
            var mealname = borsch.MealName;
            try
            {
                isWeight0 = borsch.CheckProductWeight();
                
            }
            catch (WeightException ex)
            {
                Console.WriteLine($"Product weight should not be 0: {ex.Message}");
                Console.WriteLine($"Correct weight of the product and start the program again");
                return;
            }

            finally
            {
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXX XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                
            }
            while (true)
            {
                try
                {
                    borsch.FindPoductWieghInIntervalForBorsch();
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error occured: {ex.Message}");

                }
                catch (IntervalException ex)
                {
                    Console.WriteLine($"Interval value error occured: {ex.Message}");

                }
                catch (System.OverflowException ex)
                {
                    Console.WriteLine("Checked int value > 2147483647:  " + ex.Message);

                }
            }
            var listForSalad = new FoodBase[]
            {
                new Cabbage(500),
                new Carrot(100),
                new Onion(50),
                new SunFlowerOil(100),
                new Peper(10),
                new Salt(15),
                new Garlic(0)
            };
            var salad = new Salad(listForSalad);
            mealname = salad.MealName;
            try
            {
                isWeight0 = salad.CheckProductWeight();

            }
            catch (WeightException ex)
            {
                Console.WriteLine($"Product weight should not be 0: {ex.Message}");
                Console.WriteLine($"Correct weight of the product and start the program again");
                return;
            }

            finally
            {
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXX XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            }
            salad.SortPoductInSaladByCalories();

            var listForStake = new FoodBase[]
            {
                new Beef(700),
                new SunFlowerOil(50),
                new Peper(10),
                new Salt(20)
            };
            var stake = new Stake(listForStake);
            mealname = stake.MealName;
            try
            {
                isWeight0 = stake.CheckProductWeight();

            }
            catch (WeightException ex)
            {
                Console.WriteLine($"Product weight should not be 0: {ex.Message}");
                Console.WriteLine($"Correct weight of the product and start the program again");
                return;
            }

            finally
            {
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXX XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            }
            var listForCompote = new FoodBase[]
            {
                new Water(2000),
                new Strawberry(500),
                new Sugar(50)
            };
            var compote = new Compote(listForCompote);
            mealname = compote.MealName;
            try
            {
                isWeight0 = compote.CheckProductWeight();

            }
            catch (WeightException ex)
            {
                Console.WriteLine($"Product weight should not be 0: {ex.Message}");
                Console.WriteLine($"Correct weight of the product and start the program again");
                return;
            }

            finally
            {
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXX XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            }
            var dinner = new Dinner()
            {
                Meals = new List<MealBase> { borsch, salad, stake, compote }
            };
            dinner.Cook();

        }
    }
}
