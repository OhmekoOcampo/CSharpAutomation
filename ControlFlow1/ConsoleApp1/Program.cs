using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ControlFlowOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 to 10:");

            int x = Int32.Parse(Console.ReadLine());
            string Continue = "Yes";
            
            if (x >= 1 && x <= 10)
            {
                Console.WriteLine("Number is Valid!");
            }
            else
            {
                Console.WriteLine("Number is Invalid!");
            }

            Console.WriteLine("Please enter a two numbers. Will calculate which is bigger.");
            Console.WriteLine("Enter 1st Number:");
            int numbah1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number:");
            int numbah2 = int.Parse(Console.ReadLine());
            if (numbah1 > numbah2)
            {
                Console.WriteLine("The first number {0} is the bigger number", numbah1);
            }else if(numbah2 > numbah1)
            {
                Console.WriteLine("The second number {0} is the bigger number", numbah2);
            }
            else
            {
                Console.WriteLine("Both the first and and second number are the same!");
            }
        }
    }
}
