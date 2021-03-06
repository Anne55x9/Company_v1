﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Employee
    {
        private String name;
        private int salaryPerMonth;
        

        public Employee(String name, int salaryPerMonth)
        {
            this.name = name;
            this.salaryPerMonth = salaryPerMonth;
        }

        public String GetName()
        {
            return name;
        }

        //This method can be overriden in methods in classes
        public virtual int GetSalaryPerMonth()
        { 
            return salaryPerMonth;
        }

       
    }
}
