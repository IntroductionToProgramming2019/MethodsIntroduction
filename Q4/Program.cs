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

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage("John",21);
        }
        static void PrintMessage(String name,int age)
        {
            Console.WriteLine("Hello {0}, your age is {1}", name, age);
        }
    }
}
