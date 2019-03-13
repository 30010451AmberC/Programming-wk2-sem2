using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Exercises___Part_2
{
    class Task3
    {
        static void Main(string[] args)
        {
            //Created Customer object
            Customer c1 = new Customer();

            //Prompting user for input
            Console.WriteLine("Please enter name: ");
            string name = Console.ReadLine();
            CheckString(name);
            Console.WriteLine("Complete.");
            Console.WriteLine("enter username: ");
            string username = Console.ReadLine();
            CheckString(username);
            Console.WriteLine("Complete!");
            Console.WriteLine("Enter password: ");
            string pwd = Console.ReadLine();
            CheckString(pwd);
            Console.WriteLine("Complete!");
            Console.WriteLine("Enter payment method: ");
            string payMethod = Console.ReadLine();
            CheckString(payMethod);
            Console.WriteLine("Complete!");
        }

        //Method to check if user input is valid
        static string CheckString(string input)
        {
            do
            {
                if (input == "" || input == null)
                {
                    Console.WriteLine("Please enter customer name correctly");
                    input = Console.ReadLine();
                }
            } while (input == "");
            return input;
        }
    }

    //Created Customer class
    class Customer
    {
        //Customer class properties
        private string name;
        private string username;
        private string pwd;
        private string payMethod;
        string[] shopCart = new string[4];

        //Customer properties getters and setters
        public string Name { get { return name; } set { name = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Pwd { get { return pwd; } set { pwd = value; } }
        public string PayMethod { get { return payMethod; } set { payMethod = value; } }
        public string[] ShopCart { get { return shopCart; } set { shopCart = value; } }
    }

    //Created Cart class
    class Cart
    {
        //Created Cart class properties
        private string item;
        private int code;
        private int cost;
        private int totalCost;

        //Created getters and setters for each property
        public string Item { get { return item; } set { item = value; } }
        public int Code { get { return code; } set { code = value; } }
        public int Cost { get { return cost; } set { cost = value; } }
        public int TotalCost { get { return totalCost; } set { totalCost = value; } }
    }
}
