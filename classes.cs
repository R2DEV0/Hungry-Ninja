using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Food
    {
        public string Name{get; set;}
        public int Calories{get; set;}
        public bool IsSpicy{get; set;}
        public bool IsSweet{get; set;}

        public Food(string name, int cals, bool spicy, bool sweet)
        {
            Name = name;
            Calories = cals;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }

    class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("a Pizza Pie", 500, true, false),
                new Food("nothing", 0, false, false),
                new Food("an apple", 20, false, true),
                new Food("bag o cookies", 200, false, true),
                new Food("Spicy Noodle", 80, true, false),
                new Food("giant sandwich", 1000, true, true),
                new Food("small slice of cake", 150, false, true),
            };
        }
        public Food Serve()
        {
            Random rand = new Random();
            Food item = this.Menu[rand.Next(0,6)];
            System.Console.WriteLine($"Your Ninja ate {item.Name}");
            return(item);
        }
    }

    class Ninja 
    {
        private int CalorieIntake;
        public List<Food> FoodHistory;
        public bool IsFull
        {
            get
            {
                if(CalorieIntake >= 1200)
                {
                    return true;
                }
                return false;
            }
        }

        public Ninja()
        {
            CalorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public void Eat(Food item)
        {
            Console.WriteLine($"It contains {item.Calories} calories");
            FoodHistory.Add(item);
            foreach(var x in this.FoodHistory)
            {
                CalorieIntake += x.Calories;
                if(CalorieIntake > 1200)
                {
                    System.Console.WriteLine(IsFull);
                    System.Console.WriteLine("Your Ninja is so Full!");
                    break;
                }
            }
        }
    }
}