using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLS
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        private string fname;
        private string lname;
        private int age;
        static int counter;

        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { get { return age; } set { age = value; } }

        public string ReturnDeets()
        {
            return $"{Fname} {Lname}";
        }
    }

    class ShoppingCart
    {
        private string username;
        private string password;
        private List<string> cart;
        private double cartTotal;

        public string Uname { get { return username; } set { username = value; } }
        public string Pword { get { return password; } set { password = value; } }
        public List<string> Cart { get { return cart; } set { cart = value; } }

        public double CartTotal()
        {
            return 0;
        }
    }
}
