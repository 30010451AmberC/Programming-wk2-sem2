using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 1:

            //Created new Card object 'c1'
            Card c1 = new Card();

            //Ask user to input data for c1 object
            Console.WriteLine("Please enter Cardholders name: ");
            c1.Name = Console.ReadLine();
            Console.WriteLine("Please enter Card Number: ");
            c1.CardNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Expiry date: ");
            c1.Expiry = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Security Code: ");
            c1.SecurityCode = int.Parse(Console.ReadLine());

            Console.WriteLine($"Cardholders Name: {c1.Name}\nExpiry Date: {c1.Expiry}");
        }
    }

    class Card
    {
        //Properties of Card class
        private string name;
        private int cardNum;
        private int expiry;
        private int securityCode;

        //Attributes
        public string Name { get { return name; } set { name = value; } }
        public int CardNum {private get { return cardNum; } set { cardNum = value; } }
        public int Expiry { get { return expiry; } set { expiry = value; } }
        public int SecurityCode { private get { return securityCode; } set { securityCode = value; } }

        //Constructor
        public Card()
            {
            Console.Write("A new cardholder has been created.");
            }
    }
}
