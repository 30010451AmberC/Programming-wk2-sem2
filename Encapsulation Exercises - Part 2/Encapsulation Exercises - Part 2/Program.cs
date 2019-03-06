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

            //Collect user data
            Console.WriteLine("Enter width: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length: ");
            int length = int.Parse(Console.ReadLine());

            Box b1 = new Box(width, height, length);
            Console.WriteLine(b1.SurfaceArea());
        }

    }

    //Create new class to hold dimensions of a box
    class Box
    {
        //Created 3 properties for the class
        private int width;
        private int height;
        private int length;

        //Created getters & setters for the properties
        public int Width { private get {  return width; } set { value = width; } }
        public int Height { private get { return height; } set { value = height; } }
        public int Length { private get { return length; } set { value = height; } }


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
            return $"The surface area is: {2*(Height * Width) + 2*(Height * Length) + 2*(Width *Length)}";
        }

        public int volume(int _width, int _height, int _length)
        {
            Width = _width;
            Height = _height;
            Length = _length;
            return Length * Width * Height;
        }
    }
}
