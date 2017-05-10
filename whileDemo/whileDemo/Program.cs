using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int myLitteHorse = 0;
            //while (myLitteHorse < 10)
            //{
            //    Console.WriteLine($"myLittleHorses = {myLitteHorse}");
            //    myLitteHorse++;
            //}

            do
            {
                Console.WriteLine($"myLittleHorses = {myLitteHorse}");
                myLitteHorse++;
            } while (myLitteHorse < 0);


        }
    }
}
