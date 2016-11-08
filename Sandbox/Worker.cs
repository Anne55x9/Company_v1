using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker : Employee 
    {
        public virtual string WorkerSkill
        {
            get { return WorkerSkill; }
            set { WorkerSkill = value; }
        }

        public Worker(String name, int salaryPerMonth, string Workerskill)
            : base (name, salaryPerMonth)
        {

        }

        //bla bla bla 
         

    }
}
