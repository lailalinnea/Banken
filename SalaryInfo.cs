using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banken
{
    class SalaryInfo
    {
        public string Name;
        public int Salary;
        public int Hours;

        public string ShowSalaryInfo()
        {
            return Name + " with a salary of: " + Salary;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
