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

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return length;          
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return width;                     
        }

        public int GetPerimeter()
        {
          return ((width * 2) + (length * 2));
        }

        public int GetArea()
        {

           return (width * length);
        }         

        public Rectangle()
        {

        }
    }
}
