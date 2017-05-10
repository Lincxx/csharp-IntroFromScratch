using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = string.Empty;
            while (selection != "q" && selection != "Q")
            {
                Console.Write("Enter C)elsius to Fahrenheit or F)ahrenheit to Celsius or Q)uit: ");
                selection = Console.ReadLine();
                double farenheit = 0;
                double celsius = 0;

                switch (selection)
                {
                    case "C":
                    case "c":
                        Console.WriteLine("Please enter the Celsius temperature: ");
                       
                        farenheit = TempConverter.CtoF(Console.ReadLine());
                        Console.WriteLine($"Temperature in f is {farenheit:f2}");
                        break;
                    case "F":
                    case "f":
                        Console.WriteLine("Please enter the Farenheit temperature: ");
                        
                        celsius = TempConverter.FtoC(Console.ReadLine());
                        Console.WriteLine($"Temperature in c is {celsius:f2}");
                        break;
                    case "Q":
                    case "q":
                        break;
                    default:
                        Console.WriteLine("Please Try again");
                        break;
                }
            }
        }
    }
}
