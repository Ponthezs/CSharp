using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escopo
{
    internal class Program
    {

        static string nomeDaEmpresa = "Transport GT";

        /// <summary>
        /// The main function of the program.
        /// </summary>
        /// <param name="args">This is an array of strings that contains the command-line
        /// arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine(nomeDaEmpresa);
            Console.ReadLine();
        }

        static void Exibirmsg()
        {
            Console.WriteLine(nomeDaEmpresa);
            Console.WriteLine(nomeDaEmpresa);
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Bem vindo!");
        }
    }
}
