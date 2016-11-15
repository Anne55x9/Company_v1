using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager : Employee
    {
        private int monthlyBonus;
        private int whPerMonth;


        public Manager(string name, int salaryPerMonth, int monthlyBonus)
            :base (name, salaryPerMonth)
        {
            this.monthlyBonus = monthlyBonus;
            whPerMonth = 0;

        }

        public void SetwhPerMonth(int whPerMonth)
        {
            this.whPerMonth = whPerMonth;
        }

        public override int GetSalaryPerMonth()
        {
            int totalSalary = base.GetSalaryPerMonth();

            if(whPerMonth > 180)
            {
                totalSalary = totalSalary + monthlyBonus;
            }

            return totalSalary;
        }

    }
}
