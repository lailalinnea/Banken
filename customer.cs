using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banken
{
    class CustomerInfo 
    {
        public string Name; 
        public int Balance; 
        public string ShowCustomer()
        {
            return Name + Balance;
        } 
    }
}
