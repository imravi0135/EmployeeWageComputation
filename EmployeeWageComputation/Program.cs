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
            Console.WriteLine();
            EmployeeWageComputaion wage = new EmployeeWageComputaion();
            wage.AddCompany("TATA", 20, 8, 4, 100, 20);
            wage.AddCompany("Mahindra", 30, 8, 4, 100, 20);
            wage.CalculateWage("Tata");
            wage.CalculateWage("Mahindra");
            Console.ReadLine();
        }
    }
}
