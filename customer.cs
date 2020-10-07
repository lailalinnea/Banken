using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banken
{
    class CustomerInfo 
    {
        public string Name; //  CustomerInfo list
        public int Balance;  // balance list
        public string ShowCustomerInfo() // the method where the name and balance is added together and stored until the program is exited
        {
            return Name + ": " + Balance; // print customer + their balance
        } 
    }
}
