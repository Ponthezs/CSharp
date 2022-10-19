using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        enum Cor { Azul, Verde, Amarelo, Vermelho }
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }


        static void Main(string[] args)
        {
            int contador = 0;

            /* It's a while loop. */
            while (contador < 20) // Enquanto for verdade faça
            {
                Console.WriteLine(contador);
                Console.WriteLine("Rodando o while!");
                //contador = contador + 1;
                contador++;
            }

            int contador2 = 0;

            do
            {
                Console.WriteLine("do while!");
                contador++;
            } while (contador2 < 20);

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
