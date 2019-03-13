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
        private string shopCart;

        //Customer properties getters and setters
        public string Name { get { return name; } set { name = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Pwd { get { return pwd; } set { pwd = value; } }
        public string PayMethod { get { return payMethod; } set { payMethod = value; } }
        public string ShopCart { get { return shopCart; } set { shopCart = value; } }
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
