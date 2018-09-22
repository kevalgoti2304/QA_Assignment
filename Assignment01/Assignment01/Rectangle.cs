using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Rectangle
    {
        private int length = 0;
        private int width = 0;
        private int area = 0;

        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }
        public int Area { get => area; set => area = value; }

        public void GetLength()
        {
            Console.WriteLine("\nLength of Rectangle: " + length);
        }

        public void ChangeLength(int num)
        {
            length = num;
            if (length < 1)
            {
                length = 1;
            }
            Console.WriteLine("The length of your rectangle is now: "+length);          
        }

        public void GetWidth()
        {
            Console.WriteLine("\nWidth of Rectangle: " + width);
        }

        public void ChangeWidth(int num)
        {
            width = num;
            if (width < 0)
            {
                width = 0;
            }
            Console.WriteLine("The width of your rectangle is now: " + width);          
        }

        public void GetPerimeter()
        {
            Console.WriteLine("\nRectangle Perimeter: " + ((width * 2) + (length * 2)));
        }

        public void GetArea()
        {

            Console.WriteLine("\nRectangle Area: " + width * length);
        }

        public Rectangle(int length)
        {
            this.length = length;
        }

        public Rectangle()
        {

        }
    }
}
