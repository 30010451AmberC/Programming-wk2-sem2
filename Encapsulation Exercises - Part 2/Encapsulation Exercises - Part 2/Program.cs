using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Exercises___Part_2
{
    class Program
    {
        static void Main(string[] args)
        { //07/03/19
            //Task 1
            bool confirm = false;
            int width = 0;
            int height = 0;
            int length = 0;

            //Collect user data in a loop. If input is invalid, user will be asked for data again until valid input is entered.
            do
            {
                Console.WriteLine("Enter width: ");
                width = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter height: ");
                height = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter length: ");
                length = int.Parse(Console.ReadLine());

                //Check if input is valid (not 0 or less than 0)
                bool poo = CheckInput(width, height, length);

                if (poo == false)
                {
                    //Error msg
                    Console.WriteLine("Your input was invalid, please try again.");
                }
                else
                {
                    confirm = true;
                }

                
                    
            } while (confirm == false);

            //Created new Box object called b1 and instantiated it with user input
            Box b1 = new Box(width, height, length);

            //Display surface area and volume back to user
            Console.WriteLine(b1.SurfaceArea());
            Console.WriteLine(b1.Volume());
            Console.ReadLine();
        }
        //Created method for checking input is not 0 or a negative number
        public static bool CheckInput(int width, int height, int length)//*NB: I made this method static but no idea if i should or why?
        {

                if (width != 0)
                {

                    if (width > 0)
                    {
                        if (length != 0)
                        {
                            if (length > 0)
                            {
                                if(height != 0)
                                {
                                if (height > 0)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                                }
                                else
                                {
                                return false;
                                }
                            }
                            else
                            {
                            return false;
                            }
                        }
                        else
                        {
                            return false;
                        }   
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
        }

    }

    //Create new class called Box to hold dimensions of a box
    class Box
    {
        //Created 3 properties for the class
        private int width; 
        private int height;
        private int length;

        //Created getters & setters for the properties
        public int Width { private get {  return width; } set { value = width; } }
        public int Height { private get { return height; } set { value = height; } }
        public int Length { private get { return length; } set { value = length; } }


        //Constructor
        public Box(int _width, int _height, int _length)
        {
            Width = _width;
            Height = _height;
            Length = _length;
            Console.WriteLine("Box object created");
        }

        public string SurfaceArea()
        {
            return $"Surface Area: {2*(Height * Width) + 2*(Height * Length) + 2*(Width *Length)}";
        }

        public string Volume()
        {
            return $"Volume: {Length * Width * Height}";
        }
    }
}
