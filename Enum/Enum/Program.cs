using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        enum Cor {Azul, Verde, Amarelo, Vermelho}

        static void Main(string[] args)
        {
            Cor corFavorita = Cor.Vermelho;
            Cor corfavoritadacarla = Cor.Azul;

            Console.WriteLine((int)corfavoritadacarla);
            Console.WriteLine((int)corFavorita);

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
