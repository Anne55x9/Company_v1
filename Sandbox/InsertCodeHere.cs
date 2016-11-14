using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line


            // Add you test of the Employee class and derived classes here

            Manager Man1 = new Manager("Flemming", 5000, 19 );

            //Console.WriteLine($"{Man1.GetWorkingHours()} {Man1.GetMonthlyBonus()} {Man1.GetSalaryPerMonth()}");

            Worker a = new Worker("bodil", 60, "Trommer");

            Console.WriteLine($"{a.GetName()} {a.GetSalaryPerMonth()} {a.Getskill()}");

            a.Setskill("Guitar");

            Console.WriteLine($"{a.GetName()} {a.GetSalaryPerMonth()} {a.Getskill()}");

            // The LAST line of code should be ABOVE this line
        }
    }
}
