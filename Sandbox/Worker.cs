using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker : Employee
     {

        private string skill;

        public Worker(String name, int salaryPerMonth, string skill)
            : base (name, salaryPerMonth)
        {
            this.skill = skill;
        }

        public string Getskill()
        {
            return skill;
        }

        public void Setskill(string newskill)
        {
            skill = newskill;
        }
        
      

    }
}
