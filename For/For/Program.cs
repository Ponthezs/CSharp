using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
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


            /* A for loop that is iterating through the array `palavras` and printing each element. */
            for (int contador = 0; contador < palavras.Length; contador++)
            {
                Console.WriteLine(contador);
                Console.WriteLine(palavras[contador]);
            }

            Console.WriteLine("==================================");

            for (int contador2 = palavras.Length - 1; contador2 >= 0; contador2--)
            {
                Console.WriteLine(contador2);
                Console.WriteLine(palavras[contador2]);
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
