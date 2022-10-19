using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_com_Switch
{
    internal class Program
    {
        enum Cor { Azul, Verde, Amarelo, Vermelho }
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }


        static void Main(string[] args)
        {
            Console.WriteLine("Seleceione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcsaoSelecionada = (Opcao)index;

            Console.WriteLine(opcsaoSelecionada);

            switch (opcsaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Vocé quer criar algo!");
                   break;
                case Opcao.Deletar:
                    Console.WriteLine("DELETE! DELETE IMEDIATAMENTE!”");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Editar 6 muito bom!");
                    break;
                default:
                    Console.WriteLine("Opcão não encontrada!");
                    break;
            }

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
