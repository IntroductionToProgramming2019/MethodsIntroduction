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
            PrintMessage("John");
        }
        static void PrintMessage(String name)
        {
            Console.WriteLine("Hello {0}", name);
        }
    }
}
