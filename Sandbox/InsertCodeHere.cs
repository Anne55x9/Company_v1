using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<Employee> allEmployees = new List<Employee>();


            Worker a = new Worker("bodil", 10000, "Trommer");
            Worker b = new Worker("Karl", 10000, "Guitar");
            allEmployees.Add(a);
            allEmployees.Add(b);

           // Console.WriteLine($"{a.GetName()} {a.GetSalaryPerMonth()} {a.Getskill()}");

            Manager man1 = new Manager("Frank", 30000, 10000);
            Manager man2 = new Manager("Hanne", 30000, 10000);
            man1.SetwhPerMonth(179);
            man2.SetwhPerMonth(185);
            allEmployees.Add(man1);
            allEmployees.Add(man2);

            //Console.WriteLine($"{man1.GetName()} {man1.GetSalaryPerMonth()}");

            Director dir1 = new Director("Anders", 50000);
            Director dir2 = new Director("Henrik", 50000);
            dir1.SetwhPerMonth(100);
            dir2.SetwhPerMonth(200);
            allEmployees.Add(dir1);
            allEmployees.Add(dir2);

            foreach (Employee e in allEmployees)
            {
                Console.WriteLine($"Navnet er: {e.GetName()} og lønnen er: {e.GetSalaryPerMonth()}");
            }

            //Console.WriteLine($"{dir1.GetName()} {dir1.GetSalaryPerMonth()}");

            // The LAST line of code should be ABOVE this line
        }
    }
}
