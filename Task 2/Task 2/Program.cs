using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new employee array to hold 5 (employee) objects
            Employee[] workers = new Employee[5];
            

            //Loop to collect data of 5 employees to fill workers array
            for(int i = 0; i < workers.Length; i++)
            {

                //Collecting user data and storing data in variables
                Console.WriteLine("Please enter name: ");
                string name = Console.ReadLine();
                Console.WriteLine("enter phone number: ");
                int phoneNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("enter email: ");
                string email = Console.ReadLine();
                Console.WriteLine("enter IRD number: ");
                int irdNum = int.Parse(Console.ReadLine());
                Console.WriteLine("enter bank number: ");
                int bankNum = int.Parse(Console.ReadLine());
                Console.WriteLine("enter Username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Please Password: ");
                string pwd = Console.ReadLine();
              
                //Created new Employee object and passed the data collected from user to constructor
                Employee e1 = new Employee(name, phoneNumber, email, irdNum, bankNum, username, pwd);

                //Adding the new employee object to the array.
                workers[i] = e1;
            }
            //Write back to console data recorded.
        }
    }

    class Employee
        {
        //Created properties for employee class
        private string name;
        private int phoneNumber;
        private string email;
        private int irdNum;
        private int bankNum;
        private string username;
        private string pwd;

        //Created getters & setters for each property
        public string Name { get { return name; } set { value = name; } }
        public int PhoneNumber { get { return phoneNumber; } set { value = phoneNumber; } }
        public string Email { get { return email; } set { value = email; } }
        public int IrdNum { private get { return irdNum; } set { value = irdNum; } }
        public int BankNum { private get { return bankNum; } set { value = bankNum; } }
        public string Username { get { return username; } set { value = username; } }
        public string Pwd { get { return pwd; } set { value = pwd; } }

        //Created a constructor to write to the console when a object has been created
        public Employee(string _name, int _phoneNumber, string _email, int _irdNum, int _bankNum, string _username, string _pwd)
        {
            Name = _name;
            PhoneNumber = _phoneNumber;
            Email = _email;
            IrdNum = _irdNum;
            BankNum = _bankNum;
            Username = _username;
            Pwd = _pwd;
        }

    }
}
