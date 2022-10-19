using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] produtos = new string[4]
            {
                "Size", // 0
                "Real Life", // 1
                "Portal", // 2
                "FIFA" // 3
            };

            int[] valores = { 40, 50, 60, 70, 20 }; // Forma mais simples de escrever a parte de cima //

            produtos[1] = "FIFA 2021";
            Console.WriteLine(produtos[1]);

            Console.ReadLine();
        }
        static void Exibirmsg()
        {
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Bem vindo!");
        }
    }
}
