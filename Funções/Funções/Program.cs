using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exibirmsg();
            GerarPreco(98);
            GerarPreco(78984);
            GerarPreco(88);
            GerarPreco(-55);

            int soma1 = Somar(12, 132, 21);
            int soma2 = Somar(465, 32, 71);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.ReadLine();
        }

        static void Exibirmsg() 
        {
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Bem vindo!");
        }
        static void GerarPreco(int preco)
        {
            int pecoAbs = Math.Abs(preco);
             
            Console.WriteLine("Valor final: " + preco);
            Console.WriteLine(preco);

            var valorFinal = preco + (2 * preco);
        }

        // RETORNANDO FUNÇÕES // 
        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            return  resultadoFinal;
            Console.WriteLine(resultadoFinal);
        }

    }
}
