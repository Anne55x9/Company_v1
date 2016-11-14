using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager : Employee
    {

       // public int MonthlyBonus { get; set; }
        public int WorkingHours { get; set; }
        public bool MonthlyBonus { get; set; }

        public Manager(string name, int salaryPerMonth, int WorkingHours)
            :base (name, salaryPerMonth)
        {
            
           // this.MonthlyBonus = MonthlyBonus;
            this.WorkingHours = WorkingHours; 
        }

        public virtual int GetWorkingHours()
        {
            return WorkingHours;
        }

        //public override int GetSalaryPerMonth()
        //{
        //if()STATEMENT TILmonthlybonus
        //    return base.GetSalaryPerMonth();
        //}

        //public virtual bool GetMonthlyBonus()
        //{
        //    MonthlyBonus = false;
        //    if(WorkingHours >= 18)
        //    {
        //        Console.WriteLine($"Bonus er tildelt");
        //        MonthlyBonus = true; 
        //    }
        //    return MonthlyBonus;

        //}

        //public virtual int GetWorkingHours()
        //{
        //    WorkingHours = 0;
        //    if (WorkingHours >= 18)
        //    {

        //    }



        //}
        //public virtual int GetWorkingHours()
        //{
        //    WorkingHours = 0;
        //    if (WorkingHours >= 18)
        //    {
        //        return SetMonthlyBonus();
        //    }
        //    return WorkingHours;
        //}
        //bsbsh


    }
}
