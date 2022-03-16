using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee wage Computation ");
            EmployeeWage employeeWageComputation = new EmployeeWage(20, 2, 10, 20);
            employeeWageComputation.CalculateWage();
            Console.ReadLine();
        }
    }
}
