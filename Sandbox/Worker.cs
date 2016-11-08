using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker : Employee
     {
       
        public virtual string skill { get; set; }

        public Worker(String name, int salaryPerMonth, string skill)
            : base (name, salaryPerMonth)
        {
            this.skill = skill;
        }

      

    }
}
