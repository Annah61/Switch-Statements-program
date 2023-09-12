using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 3");
            int number = int.Parse(Console.ReadLine()); //convert to an int

            switch (number)
            {
                case 1:
                    Console.WriteLine("you entered 1");
                    break;
                case 2:
                    Console.WriteLine("you entered 2");
                    break;
                case 3:
                    Console.WriteLine("you entered 3 ");
                    break;
                default: Console.WriteLine("you broke rules");
                    break;


            }
            Console.ReadLine();
        }
    }
}
