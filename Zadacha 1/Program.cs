using System;

namespace Zadacha_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForOnePage = double.Parse(Console.ReadLine());
            double priceForOneCover = double.Parse(Console.ReadLine());
            int percantageSaleForPaper = int.Parse(Console.ReadLine());
            double priceForDesigner = double.Parse(Console.ReadLine());
            int percentFromTeam = int.Parse(Console.ReadLine());

            double priceForPrinting = (priceForOnePage * 899) + (priceForOneCover * 2);
            double costsForPrintingSale = priceForPrinting - priceForPrinting * percantageSaleForPaper / 100;
            double disagnerPayment = costsForPrintingSale + priceForDesigner;
            double totalPayment = disagnerPayment - disagnerPayment * percentFromTeam / 100;

            Console.WriteLine($"Avtonom should pay {totalPayment:f2} BGN.");
        }
    }
}
