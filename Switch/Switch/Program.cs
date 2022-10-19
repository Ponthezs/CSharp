using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string cor = "Verde";
           

            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é amarelo");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é Azul");
                    break;

                default: // Quando sua resposta não for nenhuma acima
                    Console.WriteLine("Sua cor favorita eu não sei");
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
