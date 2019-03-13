using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Exercises___Part_2
{
    class Task1
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
        //Created static method for checking input is valid. (Not 0 or a negative number)
        public static bool CheckInput(int width, int height, int length)
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
        public int Width { private get {  return width; } set { width = value; } }
        public int Height { private get { return height; } set {height = value; } }
        public int Length { private get { return length; } set { length = value; } }


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

//Teachers answer (not complete but you get the idea of the loops and how to make it more simple)
/*class Program

    {

        static void Main(string[] args)

{

    int h = 0;

    int w = 0;

    int l = 0;



    h = GetData(h, "Height"); //Telling GetData() Method what is being passed. Variable h, and a string.

    w = GetData(w, "Width");

    l = GetData(l, "Length");



    Box b1 = new Box(h, w, l);



    Console.WriteLine(b1.GetSurfaceArea());





    Console.ReadLine();

}



static int GetData(int number, string info) //Passing the method the variables (ints) and the string.

{

    bool check = true;

    bool confirm = false;



    do

    {



        Console.Write($"Please enter the {info} of the box: ");

        confirm = int.TryParse(Console.ReadLine(), out number); //puts number in the out variable??? Kinda still don't understand out.

        do

        {

            if (!confirm)

            {

                Console.Clear();

                Console.Write($"Error, that was not a valid number please try again\nPlease enter the {info} of the box: ");

                confirm = int.TryParse(Console.ReadLine(), out number);

            }

        } while (!confirm);



        Console.WriteLine($"{info} Set\n\n");

        break;



    } while (check);

    return number;

}

    }



    class Box

{

    private int Height { get; set; }

    private int Width { get; set; }

    private int Length { get; set; }



    public Box(int _height, int _width, int _length)

    {

        Height = _height;

        Width = _width;

        Length = _length;

        Console.WriteLine("Box object created...");

    }



    public string GetSurfaceArea()

    {

        return $"The surface area of the box is: {2 * (Height * Width) + 2 * (Height * Length) + 2 * (Length * Width)}";

    }

} */

