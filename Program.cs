using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banken
{
    class Program
    {
        static List<CustomerInfo> customerList = new List<CustomerInfo>();
        static void Main(string[] args)
        {
            int choise = 0;
            while (choise != 7)
            {
                choise = GetChoiseFromUser();
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("You chose to add a new customer");
                        AddCustomer();
                        break;
                    case 2:
                        Console.WriteLine("You chose to remove a customer");
                        RemoveCustomer();
                        break;
                    case 3:
                        Console.WriteLine("You chose to see all the current customers");
                        ShowCustomers();
                        break;
                    case 4:
                        Console.WriteLine("You chose to see a customers balance");
                        ShowBalance();
                        break;
                    case 5:
                        Console.WriteLine("You chose to make a deposit for a customer");
                        AddBalance();
                        break;
                    case 6:
                        Console.WriteLine("You chose to make a withdrawl from a customer");
                        RemoveBalance();
                        break;
                    case 7:
                        Console.WriteLine("You chose to exit the program. Press enter to exit.");
                        Console.WriteLine("Have a good day!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("You made an unaccepable choise.");
                        break;
                }
            }


        
        }

        private static void RemoveBalance()
        {
            throw new NotImplementedException();
        }

        private static void AddBalance()
        {
            throw new NotImplementedException();
        }

        private static void ShowBalance()
        {
            throw new NotImplementedException();
        }

        private static void ShowCustomers()
        {
            foreach (CustomerInfo info in customerList)
            {
                Console.WriteLine(info.ShowCustomerInfo()); //skriver ut listan med kunder + hur mycket de har på sitt konto
            }
        }

        private static void RemoveCustomer()
        {
            throw new NotImplementedException();
        }

        private static void AddCustomer()
        {
            CustomerInfo info = new CustomerInfo();
            Console.Write("Enter the customers name here: "); //skriver ut en prompt att lägga till en ny kund
            info.Name = Console.ReadLine(); //tar in input från användare i form av ett namn för en ny kund
            customerList.Add(info); //lägger till inputen från användaren i listan med kunder

            /*CustomerInfo info2 = new CustomerInfo();
            info2.Name = "Mei";
            customerList.Add(info2);

            CustomerInfo info3 = new CustomerInfo();
            info3.Name = "Michi";
            customerList.Add(info3);*/

            /**/
        }

        private static int GetChoiseFromUser()
        {
            Console.WriteLine("Welcome to the bank!");
            Console.WriteLine(" ");
            Console.WriteLine("Choose the altenative that you want to do.");
            Console.WriteLine(" ");
            Console.WriteLine("1 : Add new customer");
            Console.WriteLine("2 : Remove a customer");
            Console.WriteLine("3 : Show all current customers");
            Console.WriteLine("4 : Show the balance of a customer");
            Console.WriteLine("5 : Make a diposit");
            Console.WriteLine("6 : Make a withdrawl");
            Console.WriteLine("7 : Exit");
            Console.WriteLine(" ");
            Console.WriteLine("Enter your choise here: ");
            string strChoise = Console.ReadLine();
            int choise = int.Parse(strChoise);
            return choise;
        }
    }
}

