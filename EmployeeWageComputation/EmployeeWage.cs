using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        public int emp_hr_per_rate = 20;//constant
        public int num_of_working_days = 2;//constant
        public int max_working_hour = 100;//constant
        public int EmpWagePerHour = 20;
        public const int is_part_time = 1;//constant
        public const int is_full_time = 2;//constant
        public int EmpDailywage = 0;
        public float TotalWage = 0;

        public EmployeeWage(int emp_hr_per_rate, int num_of_working_days, int max_working_hour, int EmpDailyWage)
        {
            this.emp_hr_per_rate = emp_hr_per_rate;
            this.num_of_working_days = num_of_working_days;
            this.max_working_hour = max_working_hour;
            this.EmpWagePerHour = EmpDailyWage;
        }

        public EmployeeWage()
        {
        }

        private int IsEmpPresent()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            return empcheck;
        }

        public void CalculateWage()
        {
            int emphr = 0;
            int empwage = 0;
            int DayNumber = 1;
            int totalemphr = 0;
            int totalworkingdays = 0;
            int totalempeage = 0;

            while (DayNumber <= max_working_hour && totalworkingdays <= num_of_working_days)
            {
                switch (IsEmpPresent())

                {
                    case is_part_time:
                        emphr = 4;
                        break;
                    case is_full_time:
                        emphr = 8;
                        break;
                    default:
                        emphr = 0;
                        break;
                }
                EmpDailywage = EmpWagePerHour + EmpWagePerHour;
                TotalWage += EmpDailywage;
                DayNumber++;
                emphr += EmpWagePerHour;

            }
            Console.WriteLine("Total working days:" + (DayNumber - 1) + "\nTotal working hours :" + emphr + "\nTotal employee wage :" + EmpDailywage);

        }

    }
    
}
