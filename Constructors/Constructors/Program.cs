using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(15, 101);

            Console.WriteLine($"emp years of service: {emp.YearsOfService}");
            Console.WriteLine($"emp office: {emp.Office}");

            Employee emp2 = new Employee();
            emp2.YearsOfService = 5;
            emp2.Office = 102;

            Console.WriteLine($"emp years of service: {emp2.YearsOfService}");
            Console.WriteLine($"emp office: {emp2.Office}");

            //Working with the default along with some initialization.
            Employee emp3 = new Employee()
            {
                YearsOfService = 20,
                Office = 301
            };

            Console.WriteLine($"emp years of service: {emp3.YearsOfService}");
            Console.WriteLine($"emp office: {emp3.Office}");

        }
    }
}
