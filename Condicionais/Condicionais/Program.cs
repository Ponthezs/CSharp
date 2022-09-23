using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 20;
            int b = 70;
            int c = 70;


            if (a == b)
            {
                Console.WriteLine("É verdade");
            } else if (c < 20)
            {
                Console.WriteLine("Executou Elseif");
            }
            else
            {
                Console.WriteLine("È mentira");
            }
               
            Console.ReadLine();
        }
    }
}
