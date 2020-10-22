using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace banken
{
    class Program
    {
        public static List<CustomerInfo> customerList = new List<CustomerInfo>();


        // when closing the program 
        // checks if there is a file in the declared path with the declared filename
        // if there is it gets deleted
        // if there isn't it is created
        static void WriteFile(string filepath, string filename, string text)
        {
            string f = filepath + filename;
            if (File.Exists(f))
            {
                File.Delete(f); 
            }
            if (Directory.Exists(filepath) == false)
            {
                Directory.CreateDirectory(filepath);
            }
            File.WriteAllText(f, text);
        }


        // when opening the program 
        // check if the file exists
        // if it does its content is returned
        // if it doesn't an empty string is returned instead
        static string ReadFile(string filename)
        {
            if (File.Exists(filename))
            {
                string text = File.ReadAllText(filename);
                return text;
            }
            return "";
        }

        static void Main(string[] args)
        {
            string filepath = @"C:\Users\fs1735\OneDrive - LYSTKOM\programering sara\prog2\uppgifter\source\repos\Banken\store\"; //declare a file patyh
            string filename = @"data.txt"; // declare a filename 

            // checks if there is a customer file when the program starts
            string text = ReadFile(filepath + filename);
            if (text != "")
            {
                string[] items = text.Split(';');
                foreach (string item in items)
                {
                    CustomerInfo ui = new CustomerInfo();
                    ui.Name = item;
                    customerList.Add(ui);
                }
            }


            int choise = 0;
            while (choise != 7)
            {
                choise = GetChoiseFromUser(); //  prints a menu and the user can enter what they want to do
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("You chose to add a new customer"); // when 1 is chosen the user is directed to here to enter new customer
                        AddCustomer(); // new customer is added
                        break;
                    case 2:
                        Console.WriteLine("You chose to remove a customer"); // chose witch customer to remove
                        RemoveCustomer();
                        break;
                    case 3:
                        Console.WriteLine("You chose to see all the current customers"); //the list with all existing customers is printed + their  balance
                        ShowCustomers();
                        break;
                    case 4:
                        Console.WriteLine("You chose to see a customers balance"); // at the moment nothing happens here
                        ShowBalance();
                        break;
                    case 5:
                        Console.WriteLine("You chose to make a deposit for a customer"); // the customer is able to add x amount of money to their account
                        AddBalance();
                        break;
                    case 6:
                        Console.WriteLine("You chose to make a withdrawl from a customer"); // the customer is able to take out x amount of money from their account
                        RemoveBalance();
                        break;
                    case 7:
                        Console.WriteLine("You chose to exit the program. Press enter to exit."); // the user exited the program
                        Console.WriteLine("Have a good day!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("You made an unaccepable choise."); // the user made a choise that isnt defined
                        break;
                }
            }


            string users = ""; // empty string
            foreach (CustomerInfo u in customerList) // goes through the lustomer list and adds them to the empty string
            {
                users += u.Name + ";";
            }
            WriteFile(filepath, filename, users); //saves the empty (now not empty) string to a file

        }

        private static void RemoveBalance()  // take out money
        {
            ShowCustomers(); 
            Console.Write("Choose which customer to withdawl money to: "); // the user choses the customer to make a withdrawl from
            string strChoise = Console.ReadLine(); // input is stored in a string
            int intChoise = int.Parse(strChoise); // the string is converted to an int

            Console.Write("How much money do you want to withdawl?: "); // the user enters the amount of money to withdraw from the account
            string strWithdrawl = Console.ReadLine(); // input is stored in a string
            int intWithdrawl = int.Parse(strWithdrawl); // the string is converted to an int
            customerList[intChoise].Balance -= intWithdrawl; // the money is subtracted
        }

        private static void AddBalance() // add money
        {
            ShowCustomers();
            Console.Write("Choose which customer to deposit money to: "); // user choses who to deposit money to
            string strChoise = Console.ReadLine(); // inout from user is stored in a string
            int intChoise = int.Parse(strChoise); // the input string is converted to an int

            Console.Write("How much money do you want to deposit?: "); // user choses how much money to deposit
            string strDeposit = Console.ReadLine(); // input from user is stored in a string
            int intDeposit = int.Parse(strDeposit); // the string is converted to an int
            customerList[intChoise - 1].Balance += intDeposit;  // the money is added to the account

        }

        private static void ShowBalance() // curently doesn't do anything
        {
            throw new NotImplementedException();
        }

        private static void ShowCustomers() // prints the customer list + their respective balance
        {
            for (int i = 0; i < customerList.Count; i++)
            {
                Console.WriteLine( ( i + 1 ) + ": " + customerList[i].ShowCustomerInfo()); // i starts on one so 1 + 1 so that the list will start one one and not zero
                                                                                           // then i in customer list is added to the string and name and balace is printed
            }
        }

        private static void RemoveCustomer() // remove a customer from the customer list
        {
            ShowCustomers();
            Console.Write("Which customer do you want to remove?: "); // the customer is chosen
            string strChoise = Console.ReadLine();
            int intChoise = int.Parse(strChoise); // the string is converted to an int
            customerList.RemoveAt(intChoise); // the user is removed
        }

        private static void AddCustomer() // add a customer to the customer list
        {
            CustomerInfo info = new CustomerInfo();
            Console.Write("Enter the customers name here: "); //skriver ut en prompt att lägga till en ny kund
            info.Name = Console.ReadLine(); //tar in input från användare i form av ett namn för en ny kund
            customerList.Add(info); //lägger till inputen från användaren i listan med kunder

        }

        private static int GetChoiseFromUser()  // the menu that gets printed at the start
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
            string strChoise = Console.ReadLine(); // input from user stored in a string
            int choise = int.Parse(strChoise);  // the input string gets converted to an int
            return choise; // the int value is returned to main
        }
    }
}

