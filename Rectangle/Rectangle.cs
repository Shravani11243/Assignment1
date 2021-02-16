using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class RectangleClass
    {
        private int length_rectngle;
        private int width_rectngle;

        //Default comstructor
        public  RectangleClass()
        {
         length_rectngle = 1;
         width_rectngle = 1;
    }
        //
        public RectangleClass(int givenLength,int givenWidth)
        {
            length_rectngle = givenLength;
            width_rectngle = givenWidth;
        }
        //six Methods
        public int GetWidth()
        {
            return width_rectngle;
        }
        public int GetLength()
        {
            return length_rectngle;
        }
        public int SetLength( int length)
        {
            return length_rectngle = length;
        }
        public int SetWidth(int width)
        {
            return length_rectngle = width;
        }
        public int GetPerimeter()
        {
            int Perimeter = length_rectngle + width_rectngle;
            return (2 * (Perimeter));
        }
        public int GetArea()
        {
            return (length_rectngle * width_rectngle);
        }
    }
}
