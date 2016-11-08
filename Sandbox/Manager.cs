using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager : Employee
    {

        public int MonthlyBonus { get; set; }
        public int WorkingHours { get; set; }

        public Manager(string name, int salaryPerMonth, int MonthlyBonus, int WorkingHours)
            :base (name, salaryPerMonth)
        {
            
            this.MonthlyBonus = MonthlyBonus;
            this.WorkingHours = WorkingHours; 
        }

        public virtual int GetMonthlyBonus()
        {
            return MonthlyBonus;
        }

        public virtual int GetWorkingHours()
        {
            WorkingHours = 0;
            if (WorkingHours >= 18)
            {
                return MonthlyBonus;
            }
            return WorkingHours;
        }
        //bsbsh


    }
}
