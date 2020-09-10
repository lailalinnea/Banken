using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_template_exercise
{
    class InkomstInfo
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Hours { get; set; }
        public int Hourlypay { get { return Salary / Hours; } }
    }
}
