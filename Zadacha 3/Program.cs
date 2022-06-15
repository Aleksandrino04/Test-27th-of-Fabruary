using System;

namespace Zadacha_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string breed = Console.ReadLine();
            string sex = Console.ReadLine();
            double catMonths = 0;
            bool zmei = false;

            if (breed == "British Shorthair")
            {
                if (sex == "m")
                {
                    catMonths = (13 * 12) / 6;
                    

                }
                else
                {
                    catMonths = (14 * 12) / 6;
                   
                }
            }

            else if(breed == "Siamese")
            {
                if (sex == "m")
                {
                    catMonths = (15 * 12) / 6;
                    
                }
                else
                {
                    catMonths = (16 * 12) / 6;
                   
                }
            }
            else if (breed == "Persian")
            {
                if (sex == "m")
                {
                    catMonths = (14 * 12) / 6;
                    
                }
                else
                {
                    catMonths = (15 * 12) / 6;
                   
                }
            }
            else if (breed == "Ragdoll")
            {
                if (sex == "m")
                {
                    catMonths = (16 * 12) / 6;

                   
                }

                else
                {
                    catMonths = (17 * 12) / 6;
                   
                }
            }
            else if (breed == "American Shorthair")
            {
                if (sex == "m")
                {
                    catMonths = (12 * 12) / 6;
                   
                }
                else
                {
                    catMonths = (13 * 12) / 6;
                 
                }
                
            }
            else if(breed == "Siberian")
            {
                if (sex == "m")
                {
                    catMonths = (11 * 12) / 6;
                    
                }
                else
                {
                    catMonths = (12 * 12) / 6;
                    
                }
               
            }
            else
            {
                Console.WriteLine("Tom is invalid cat!");
                return;
            }


            if (zmei == false)
            {
                Console.WriteLine($"{Math.Floor(catMonths)} cat months");


            }


        }
    }
}
