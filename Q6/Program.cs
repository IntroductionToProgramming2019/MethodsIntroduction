/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : Introduction to Methods
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            double circleArea = CalculateCircleArea(3.45);
            Console.WriteLine("circleArea = {0}",circleArea);
        }
        static double CalculateCircleArea(double radius)
        {

            double area = Math.PI * (Math.Pow(radius, 2));
            double roundedArea = Math.Round(area, 2);
            return roundedArea;
        }
    }
}
