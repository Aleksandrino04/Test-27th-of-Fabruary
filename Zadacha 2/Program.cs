using System;

namespace Zadacha_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int processorNumber = int.Parse(Console.ReadLine());
            int employeesNumber = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            double totalHours = 8 * workDays * employeesNumber;
            double processorForThatTime = Math.Floor(totalHours / 3);
            double losses = (processorNumber - processorForThatTime) * 110.10;
            double profit = (processorForThatTime - processorNumber) * 110.10;

            if (processorNumber <= processorForThatTime)
            {
                Console.WriteLine($"Profit: -> {profit:f2} BGN");
             
            }
            else
            {
                Console.WriteLine($"Losses: -> {losses:f2} BGN");
            }


        }
    }
}
