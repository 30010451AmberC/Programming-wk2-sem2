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

            Console.WriteLine(surfaceArea(width, height, length));
        }

    }

    //Create new class to hold dimensions of a box
    class box
    {
        //Created 3 properties for the class
        private int width;
        private int height;
        private int length;

        //Created getters & setters for the properties
        public int Width { private get {  return width; } set { value = width; } }
        public int Height { private get { return height; } set { value = height; } }
        public int Length { private get { return length; } set { value = height; } }

        public box()
        {

        }

        public int surfaceArea(int _width, int _height, int _length)
        {
            Width = _width;
            Height = _height;
            Length = _length;
            return 2*(Height * Width) + 2*(Height * Length) + 2*(Width *Length);
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
