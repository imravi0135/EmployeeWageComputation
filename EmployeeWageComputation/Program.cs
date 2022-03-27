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
            Console.WriteLine("Hello welcome to EmpWage problem");

            Console.WriteLine("Welcome to the Employee Wage Computation Problem");
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 20, 100);
            empWageBuilder.addCompanyEmpWage("PVP", 30, 24, 160);
            empWageBuilder.computeEmpWage();
            Console.ReadLine();
        }
    }
}
