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

            var a = 10;
            int b = 20;
            int c = 200;

            // (E) && e || (OU/OR)

            //TRUE && TRUE =  TRUE
            //FALSE && FALSE = FALSE
            //FALSE && TRUE = FALSE
            //TRUE && FALSE = FALSE

           //TRUE || FALSE = TRUE, TENDO UM VERDADEIRO SEMPRE SERÁ VERDADEIRO PRECISA DE UMA CONDIÇÃO TRUE, CASO N SEJA SERÁ FALSE

           //TRUE || TRUE =  TRUE
           //FALSE || TRUE = TRUE
           //TRUE || FALSE = TRUE
           //FALSE || FALSE = FALSE


            if (a < b || a > c) // SE
            {
                Console.WriteLine("É verdade");
            } else if (c < 20)
            {
                Console.WriteLine("Executou Elseif");
            }
            else // SE NÃO
            {
                Console.WriteLine("È mentira");
            }
               
            Console.ReadLine();
        }
    }
}
