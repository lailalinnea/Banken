using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_template_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            InkomstInfo info = new InkomstInfo();
            Console.Write("Enter your name: ");
            info.Name = Console.ReadLine();
            Console.Write("Enter your salary: ");
            info.Salary = int.Parse(Console.ReadLine());
            Console.Write("Enter your work hours: ");
            info.Hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Your hourly par is: " + info.Hourlypay + " kr/h");
            Console.ReadKey();

            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your salary: ");
            int salary = int.Parse(Console.ReadLine());
            Console.Write("Enter your work hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Your hourly salary is :" + (salary / hours) + " kr/h");
            Console.ReadKey();*/
        }
    }
}
