using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int RectangleArea = CalculateRectangleArea(4, 8);
            Console.WriteLine("The area of the rectangle is {0}",RectangleArea );
        }
        static int CalculateRectangleArea(int length, int width)
        {
            int area = length * width;
            return area;
        }
    }
}
