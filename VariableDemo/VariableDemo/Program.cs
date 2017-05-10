using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 21; //that's a lie
            int x = 5;
            double myHourlyRate = 150.00;
            var myName = "Jeremy";

            Console.WriteLine($"myAge: {myAge}, x: {x}, myHourlyRate: {myHourlyRate}, myName: {myName}");

            myAge = 35;
            x = 20;
            myHourlyRate = 84.00;
            myName = "Josh";

            Console.WriteLine($"myAge: {myAge}, x: {x}, myHourlyRate: {myHourlyRate}, myName: {myName}");
        }
    }
}
