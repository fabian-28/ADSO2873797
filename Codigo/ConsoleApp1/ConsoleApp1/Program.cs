using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("digite el numero a revisar");
            a=int.Parse(Console.ReadLine());
            if (a % 2 ==0)
            {
                Console.WriteLine("el numero es par");
            }
            else
            {
                Console.WriteLine("no es numero par");
            }
        }
    }
}
