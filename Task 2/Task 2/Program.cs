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
        }
    }

    class Employee
        {
        private string name;
        private int phoneNumber;
        private string email;
        private int irdNum;
        private int bankNum;
        private string username;
        private string pwd;

        public string Name { get { return name; } set { value = name; } }
        public int PhoneNumber { get { return phoneNumber; } set { value = phoneNumber; } }
        public string Email { get { return email; } set { value = email; } }
        public int IrdNum { private get { return irdNum; } set { value = irdNum; } }
        public int BankNum { private get { return bankNum; } set { value = bankNum; } }
        public string Username { get { return username; } set { value = username; } }
        public string Pwd { get { return pwd; } set { value = pwd; } }

    }
}
