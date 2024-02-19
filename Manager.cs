using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest19._2._2024
{
    public class Manager : Employee
    {
        // Properties
        public double BonusValue { get; set; }

        // Constructor
        public Manager (double bonusValue, double hourlyPay, string employeeNumber, string jobTitle) : base(hourlyPay, employeeNumber, jobTitle)
        {
            BonusValue = bonusValue;
        }

        public override void SetPay(int WeekNumber, double NumberOfHours)
        {
            double PercentageIncrease = 1 + (BonusValue / 100);
            double AdjustedHours = NumberOfHours * PercentageIncrease;
            base.SetPay(WeekNumber, AdjustedHours);
        }
    }
}
