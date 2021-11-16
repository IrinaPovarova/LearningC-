﻿using System;
using System.Collections.Generic;
using System.Text;
using Exceptions;

namespace OOP.Meals
{
    public abstract class MealBase

    {
        public FoodBase[] _products;
        public string MealName { get; set; }
        public object itemName { get; private set; }

        public MealBase(FoodBase[] products)
        {
            _products = products;
        }
        public bool CheckProductWeight()
        {
            bool isWeight0 = false;
            foreach (var item in _products)
            {

                if (item.Weight == 0)
                {
                    isWeight0 = true;
                    int itemWeight = item.Weight;
                    var itemName = item.Name;
                    throw new WeightException($"Weight of the {item.Name} = 0");
                 }
            }
            return isWeight0;
        }

        public void ShowComponents()
        {
            foreach (var item in _products)
            {
                _ = item.ToString();
            }
        }
        public double GetTotalCalories()
        {
            double calories_total = 0;
            foreach (var item in _products)
            {
                calories_total = calories_total + (item.Calories * item.Weight) / 100;
            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"Total calories - {calories_total}cal");
            return calories_total;
        }
        public int GetTotalWeight()
        {
            int weight_total = 0;
            foreach (var item in _products)
            {
                weight_total += item.Weight; ;
            }
            Console.WriteLine($"Total weight - {weight_total}g");
            Console.WriteLine("----------------------------------------------------------");
            return weight_total;
        }
        public abstract void Cook();

    }
}
