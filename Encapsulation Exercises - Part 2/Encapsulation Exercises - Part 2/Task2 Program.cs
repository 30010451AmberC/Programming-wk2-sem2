using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Exercises___Part_2
{
    class Task2
    {
        static void Main(string[] args)
        {
            //Task 2
            //Create student object and prompting user for input whilst checking if input is valid before moving onto next
            Students s1 = new Students();
            Console.WriteLine("Please enter student name: ");
            string name = Console.ReadLine();
            CheckString(name);
            s1.Name = name;
            Console.WriteLine("Complete");
            Console.WriteLine("Please enter student email: ");
            string email = Console.ReadLine();
            CheckString(email);
            s1.Email = email;
            Console.WriteLine("Complete");
            Console.WriteLine("Please enter student address: ");
            string address = Console.ReadLine();
            CheckString(address);
            s1.Address = address;
            Console.WriteLine("Complete");
            Console.WriteLine("Please enter student username: ");
            string username = Console.ReadLine();
            CheckString(username);
            s1.Username = username;
            Console.WriteLine("Complete");
            Console.WriteLine("Please enter student password: ");
            string pswd = Console.ReadLine();
            CheckString(pswd);
            s1.Pswd = pswd;
            Console.WriteLine("Complete");
            Console.WriteLine("Please enter student Emergency Contact: ");
            string emergencyContact = Console.ReadLine();
            CheckString(emergencyContact);
            s1.EmergencyContact = emergencyContact;
            Console.WriteLine("Complete");
            //Prompting user for the 4 grades and checking if the input is valid before moving on
            Console.WriteLine("Please enter students grade for Topic 1: ");
            int grade1 = int.Parse(Console.ReadLine());
            CheckNum(grade1, "Topic 1");
            s1.Grade[0] = grade1;
            Console.WriteLine("Complete");
            Console.WriteLine("Please enter students grade for Topic 2: ");
            int grade2 = int.Parse(Console.ReadLine());
            CheckNum(grade2, "Topic 2");
            s1.Grade[1] = grade2;
            Console.WriteLine("Complete");
            Console.WriteLine("Please enter students grade for Topic 3: ");
            int grade3 = int.Parse(Console.ReadLine());
            CheckNum(grade3, "Topic 3");
            s1.Grade[2] = grade3;
            Console.WriteLine("Complete");
            Console.WriteLine("Please enter students grade for Topic 4: ");
            int grade4 = int.Parse(Console.ReadLine());
            CheckNum(grade4, "Topic 4");
            s1.Grade[3] = grade4;
            Console.WriteLine("Complete");

            Console.ReadLine();
        }

        //Method to check if user input is valid. Loop until valid input is entered
        static string CheckString(string input)
        {
            do
            {
                if (input == "" || input == null)
                {
                    Console.WriteLine("Please enter a student name correctly");
                    input = Console.ReadLine();
                }
            } while (input == "");
            return input;          
        }

        //Method to check if user input is valid. Loop until valid input is entered
        static int CheckNum(int number, string topic)
        {
            bool check = false;
            bool confirm = true;
            do
            {
                Console.WriteLine("Please enter grade 1: ");
                check = int.TryParse(Console.ReadLine(), out number);
                do
                {
                    if (!check)
                    {

                        Console.WriteLine($"Invalid input entered. Please enter students grade for {topic} :");
                        check = int.TryParse(Console.ReadLine(), out number); //This returns a bool value but also stores the input into the number variable IF input is a NUMBER.
                    }
                } while (!check);
                Console.WriteLine($"{topic} has been set");
                break;
            } while (confirm);
            return number; //Returning valid number
        }
    }

    //Created Student class to hold students details.
    class Students
    {
        //Creating properties for the Students() class
        private string name;
        private string email;
        private string address;
        private string username;
        private string pswd;
        private string emergencyContact;
        //Create an array of size 4 to hold grades
        int[] grade = new int[4];

        //Created getters and setters for each of the properties, with Name, Username, and Grades being set to public getters.
        public string Name { get { return name; } set { name = value; } }
        public string Email { private get { return email; } set { email = value; } }
        public string Address { private get { return address; } set { address = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Pswd { private get { return pswd; } set { pswd = value; } }
        public int[] Grade { get { return grade; } set { grade = value; } }
        public string EmergencyContact { private get { return emergencyContact; } set { emergencyContact = value; } }

        //Constructor for Student class
        public Students()
        {
            Console.WriteLine("Student record has been created");
        }

        //Method calculates the average of all 4 topic grades and displays it to the screen after displaying all the student record that is public
        public string StudentRecord()
        {
            double average = 0;
            foreach (int x in grade)
                average += x;
            average = average / grade.Length;
            return $"Student Name: {Name} \nStudent Username/ID: {Username} \nGrade1: {grade[0]} \nGrade2: {grade[1]} \nGrade3: {grade[2]} \nGrade4: {grade[3]}\nAverage: {average}";
        }

    }
}
