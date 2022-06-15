using System;

namespace Zadacha_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int boughFoodQuantity = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            boughFoodQuantity *= 1000;
            double totalFood = 0;

            while (comand != "Adopted")
            {
                int eatenFood = int.Parse(comand);
                totalFood += eatenFood;
                comand = Console.ReadLine();
            }
            if (boughFoodQuantity >= totalFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {boughFoodQuantity-totalFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(totalFood-boughFoodQuantity)} grams more.");

            }















        }
    }
}