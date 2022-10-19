using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        enum Cor { Azul, Verde, Amarelo, Vermelho }
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }


        /// <summary>
        /// The main function of the program.
        /// </summary>
        /// <param name="args">This is an array of strings that contains the command-line
        /// arguments.</param>
        static void Main(string[] args)
        {
            string[] palavras = { "Lions", "Lima", "Guia", "Dev", "Node" };

            /* A loop that will iterate through the array `palavras` and print each element. */
            foreach (string palavras in palavras)
            {
                Console.WriteLine("Forach Rodando");
            }



            Console.WriteLine("Fim da Linha!!!!");
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
