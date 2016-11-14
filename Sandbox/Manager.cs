using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager : Employee
    {
        private int monthlyBonus;
        
        private int workinghours;


        public Manager(string name, int salaryPerMonth, int workinghours )
            :base (name, salaryPerMonth)
        {
            
           this.monthlyBonus = 4000;
            
        }

        public virtual int GetWorkingHours()
        {
            return workinghours;
        }

        public virtual int GetMonthlyBonus(int workinghours)
        {
            if(workinghours >= 180)
            {
              return base.GetSalaryPerMonth() + monthlyBonus;
            }
            return base.GetSalaryPerMonth();
        }

        public 




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
