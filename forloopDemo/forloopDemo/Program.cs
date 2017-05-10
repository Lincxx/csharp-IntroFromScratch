using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 300; i++)
            {
                Console.WriteLine($"Hello {i.ToString()}");
            }
        }
    }
}
