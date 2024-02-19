using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest19._2._2024
{
    public class Employee
    {
        // Fields
        private double[] PayYear2022 = new double[52];

        // Properties
        public double HourlyPay {  get; set; }
        public string EmployeeNumber { get; set; }
        public string JobTitle { get; set; }

        // Constructor
        public Employee (double hourlyPay, string employeeNumber,  string jobTitle)
        {
            HourlyPay = hourlyPay;
            EmployeeNumber = employeeNumber;
            JobTitle = jobTitle;
        }

        public string GetEmployeeNumber()
        {
            return EmployeeNumber;
        }

        public virtual void SetPay(int WeekNumber, double NumberOfHours)
        {
            double TotalPay = NumberOfHours * HourlyPay;
            PayYear2022[WeekNumber - 1] = TotalPay;
        }

        public double GetTotalPay()
        {
            double output = 0;
            foreach (double i in PayYear2022)
            {
                output += i;
            }
            return output;
        }
    }
}
