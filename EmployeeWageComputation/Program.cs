﻿using System;
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
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.DailyEmployeeWage();
            Console.ReadKey();
        }
    }
}